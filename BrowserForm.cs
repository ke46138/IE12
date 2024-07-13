// Copyright © 2010-2015 The CefSharp Authors. All rights reserved.
//
// Use of this source code is governed by a BSD-style license that can be found in the LICENSE file.
using CefSharp;
using CefSharp.DevTools.IO;
using CefSharp.MinimalExample.WinForms.Controls;
using CefSharp.WinForms;
using System;
using System.Net;
using System.Windows.Forms;
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace CefSharp.MinimalExample.WinForms
{
    public partial class BrowserForm : Form
    {
#if DEBUG
        private const string Build = "Debug 12.126.0.0"; // 12 - IE12 version, 126 - chromium version, 0.0 - IE12 version
#else
        private const string Build = "Release 12.126.0.0"; // 12 - IE12 version, 126 - chromium version, 0.0 - IE12 version
#endif
        private readonly string title = "IE12 (" + Build + ")";
        private readonly ChromiumWebBrowser browser;
        private bool isBackBlue = false;
        private bool isForwardBlue = false;
        private int j = 0;
        private int x = 0;
        public BrowserForm()
        {
            InitializeComponent();

            Text = title;
            WindowState = FormWindowState.Maximized;

            browser = new ChromiumWebBrowser("bing.com");
            toolStripContainer.ContentPanel.Controls.Add(browser);

            browser.IsBrowserInitializedChanged += OnIsBrowserInitializedChanged;
            browser.LoadingStateChanged += OnLoadingStateChanged;
            browser.ConsoleMessage += OnBrowserConsoleMessage;
            browser.StatusMessage += OnBrowserStatusMessage;
            browser.TitleChanged += OnBrowserTitleChanged;
            browser.AddressChanged += OnBrowserAddressChanged;
            browser.LoadError += OnBrowserLoadError;
            //button1.ContextMenuStrip = settingsContextMenuStrip;
            var version = string.Format("Chromium: {0}, CEF: {1}, CefSharp: {2}",
               Cef.ChromiumVersion, Cef.CefVersion, Cef.CefSharpVersion);

#if NETCOREAPP
            // .NET Core
            var environment = string.Format("Environment: {0}, Runtime: {1}",
                System.Runtime.InteropServices.RuntimeInformation.ProcessArchitecture.ToString().ToLowerInvariant(),
                System.Runtime.InteropServices.RuntimeInformation.FrameworkDescription);
#else
            // .NET Framework
            var bitness = Environment.Is64BitProcess ? "x64" : "x86";
            var environment = String.Format("Environment: {0}", bitness);
#endif

            DisplayOutput(string.Format("{0}, {1}", version, environment));
        }
        
        private void OnBrowserLoadError(object sender, LoadErrorEventArgs e)
        {
            //Actions that trigger a download will raise an aborted error.
            //Aborted is generally safe to ignore
            if (e.ErrorCode == CefErrorCode.Aborted)
            {
                return;
            }
            var failUrl = e.FailedUrl;
            var errText = e.ErrorText;
            var errCode = e.ErrorCode;
            var errorHtml = $"<!DOCTYPE html>\r\n<html lang=\"ru\">\r\n<head>\r\n    <meta charset=\"UTF-8\">\r\n    <meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\">\r\n    <title>Не удается открыть эту страницу</title>\r\n</head>\r\n<body style=\"font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif; margin: 0; padding: 0; background-color: #f9f9f9;\">\r\n    <div style=\"width: 600px; margin: 100px auto; padding: 20px; background-color: #ffffff; border: 1px solid #d3d3d3; box-shadow: 0px 0px 10px rgba(0,0,0,0.1}};\">\r\n        <div style=\"font-size: 24px; color: #0078d7; margin-bottom: 20px;\">Не удается открыть эту страницу</div>\r\n        <div style=\"font-size: 16px; color: #333333;\">\r\n            <p>Причины, по которым это может происходить:</p>\r\n            <ul style=\"padding-left: 20px;\">\r\n                <li>Проблемы с подключением к Интернету</li>\r\n                <li>Веб-сайт недоступен</li>\r\n                <li>Введен неправильный URL-адрес</li>\r\n                <li>Проблемы с сервером веб-сайта</li>\r\n            </ul>\r\n            <p>Проверьте подключение к Интернету и попробуйте снова.</p>\r\n\t\t\t<p>{errText}</p>\r\n        </div>\r\n        <div style=\"margin-top: 30px; font-size: 12px; color: #999999;\">\r\n            <p>Internet Explorer 12</p>\r\n        </div>\r\n    </div>\r\n</body>\r\n</html>\r\n";
            

            _ = e.Browser.SetMainFrameDocumentContentAsync(errorHtml);

            //AddressChanged isn't called for failed Urls so we need to manually update the Url TextBox
            this.InvokeOnUiThreadIfRequired(() => urlTextBox.Text = e.FailedUrl);
        }

        private void OnIsBrowserInitializedChanged(object sender, EventArgs e)
        {
            var b = ((ChromiumWebBrowser)sender);

            this.InvokeOnUiThreadIfRequired(() => b.Focus());
        }

        private void OnBrowserConsoleMessage(object sender, ConsoleMessageEventArgs args)
        {
            DisplayOutput(string.Format("Line: {0}, Source: {1}, Message: {2}", args.Line, args.Source, args.Message));
        }

        private void OnBrowserStatusMessage(object sender, StatusMessageEventArgs args)
        {
            this.InvokeOnUiThreadIfRequired(() => statusLabel.Text = args.Value);
        }

        private void OnLoadingStateChanged(object sender, LoadingStateChangedEventArgs args)
        {
            SetCanGoBack(args.CanGoBack);
            SetCanGoForward(args.CanGoForward);

            this.InvokeOnUiThreadIfRequired(() => SetIsLoading(!args.CanReload));
        }

        private void OnBrowserTitleChanged(object sender, TitleChangedEventArgs args)
        {
            this.InvokeOnUiThreadIfRequired(() => Text = title + " - " + args.Title);
        }

        private void OnBrowserAddressChanged(object sender, AddressChangedEventArgs args)
        {
            this.InvokeOnUiThreadIfRequired(() => urlTextBox.Text = args.Address);
        }

        private void SetCanGoBack(bool canGoBack)
        {
            //this.InvokeOnUiThreadIfRequired(() => backButton.Enabled = canGoBack);
            //checkNavButton();
            if (canGoBack == true)
            {
                if (isBackBlue == false)
                {
                    if (j == 0) {
                        backButton.Image = Properties.Resources.backBlue;
                        backButton.ImageTransparentColor = System.Drawing.Color.White;
                        isBackBlue = true;
                        j++;
                    }
                }
            }
            else
            {
                if (isBackBlue == true)
                {
                    if (j == 1) {
                        backButton.Image = Properties.Resources.backNotBlue;
                        backButton.ImageTransparentColor = System.Drawing.Color.White;
                        isBackBlue = false;
                        j = 0;
                    }
                }
            }
        }

        private void SetCanGoForward(bool canGoForward)
        {
            //this.InvokeOnUiThreadIfRequired(() => forwardButton.Enabled = canGoForward);
            //checkNavButton();
            if (canGoForward == true)
            {
                if (isForwardBlue == false)
                {
                    if (x == 0)
                    {
                        forwardButton.Image = Properties.Resources.ForwoardBlue;
                        forwardButton.ImageTransparentColor = System.Drawing.Color.White;
                        isForwardBlue = true;
                        x++;
                    }
                }
            }
            else
            {
                if (isForwardBlue == true)
                {
                    if (x == 1)
                    {
                        forwardButton.Image = Properties.Resources.ForwoardNotBlue;
                        forwardButton.ImageTransparentColor = System.Drawing.Color.White;
                        isForwardBlue = false;
                        x = 0;
                    }
                }
            }
        }

        private void SetIsLoading(bool isLoading)
        {
            goButton.Text = isLoading ?
                "Остановить" :
                "Обновить";
            goButton.Image = isLoading ?
                Properties.Resources.xP :
                Properties.Resources.refresh;

            HandleToolStripLayout();
        }

        public void DisplayOutput(string output)
        {
            this.InvokeOnUiThreadIfRequired(() => outputLabel.Text = output);
        }

        private void HandleToolStripLayout(object sender, LayoutEventArgs e)
        {
            HandleToolStripLayout();
        }

        private void HandleToolStripLayout()
        {
            var width = toolStrip1.Width;
            foreach (ToolStripItem item in toolStrip1.Items)
            {
                if (item != urlTextBox)
                {
                    width -= item.Width - item.Margin.Horizontal;
                }
            }
            urlTextBox.Width = Math.Max(0, width - urlTextBox.Margin.Horizontal - 18);
        }

        private void ExitMenuItemClick(object sender, EventArgs e)
        {
            browser.Dispose();
            Cef.Shutdown();
            Close();
        }

        private void GoButtonClick(object sender, EventArgs e)
        {
            LoadUrl(urlTextBox.Text);
        }

        private void BackButtonClick(object sender, EventArgs e)
        {
            browser.Back();
        }

        private void ForwardButtonClick(object sender, EventArgs e)
        {
            browser.Forward();
        }

        private void UrlTextBoxKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter)
            {
                return;
            }

            LoadUrl(urlTextBox.Text);
        }

        private void LoadUrl(string urlString)
        {
            // No action unless the user types in some sort of url
            if (string.IsNullOrEmpty(urlString))
            {
                return;
            }

            Uri url;

            var success = Uri.TryCreate(urlString, UriKind.RelativeOrAbsolute, out url);

            // Basic parsing was a success, now we need to perform additional checks
            if (success)
            {
                // Load absolute urls directly.
                // You may wish to validate the scheme is http/https
                // e.g. url.Scheme == Uri.UriSchemeHttp || url.Scheme == Uri.UriSchemeHttps
                if (url.IsAbsoluteUri)
                {
                    browser.LoadUrl(urlString);

                    return;
                }

                // Relative Url
                // We'll do some additional checks to see if we can load the Url
                // or if we pass the url off to the search engine
                var hostNameType = Uri.CheckHostName(urlString);

                if (hostNameType == UriHostNameType.IPv4 || hostNameType == UriHostNameType.IPv6)
                {
                    browser.LoadUrl(urlString);

                    return;
                }

                if (hostNameType == UriHostNameType.Dns)
                {
                    try
                    {
                        var hostEntry = Dns.GetHostEntry(urlString);
                        if (hostEntry.AddressList.Length > 0)
                        {
                            browser.LoadUrl(urlString);

                            return;
                        }
                    }
                    catch (Exception)
                    {
                        // Failed to resolve the host
                    }
                }
            }

            // Failed parsing load urlString is a search engine
            var searchUrl = "https://bing.com/search?q=" + Uri.EscapeDataString(urlString);

            browser.LoadUrl(searchUrl);
        }

        private void ShowDevToolsMenuItemClick(object sender, EventArgs e)
        {
            browser.ShowDevTools();
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            settingsContextMenuStrip.Show(Cursor.Position);
        }

        private void Home_Click(object sender, EventArgs e)
        {
            browser.LoadUrl("bing.com");
        }

        private void debugButton_Click(object sender, EventArgs e)
        {
            Form Form2 = new BrowserForm();
            Form2.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            browser.LoadUrl("https://github.com/ke46138/IE12");
        }
    }
}
