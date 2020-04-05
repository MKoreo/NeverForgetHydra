﻿using CMDT;
using CMIF;
using Newtonsoft.Json;
using SPDT;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPIF
{
    public partial class FormFeedback : ThemedForm
    {
        public string feedback;
        public FormFeedback(FormMain test, Theme theme, Settings settings) : base(settings)
        {
            InitializeComponent();
            this.theme = theme;
            this.settings = settings;
            applyTheming();
            applyAddTheming();
        }

        private void applyAddTheming()
        {
            //Add button specific
            btnSend.BackColor = theme.highlight;
            btnSend.ForeColor = theme.text;

            lblFeedback.BackColor = theme.tint1;
            lblFeedback.ForeColor = theme.text;

            rtbFeedback.BackColor = theme.background;
            rtbFeedback.ForeColor = theme.text;

            //Update Window
            this.Invalidate();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            feedback = rtbFeedback.Text;
             var httpWebRequest = (HttpWebRequest)WebRequest.Create("https://maker.ifttt.com/trigger/NFH_Feedback/with/key/dCq5A5cuAQPzkJGupi9fxz");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";
            string name = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            int cut = name.LastIndexOf('\\') + 1;
            name = name.Substring(cut);
            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                string json = "{\"value1\":\"" + name + "\"," +
                              "\"value2\":\"" + feedback + "\"}";

                streamWriter.Write(json);
            }

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
            }
            this.Close();
        }
    }
}