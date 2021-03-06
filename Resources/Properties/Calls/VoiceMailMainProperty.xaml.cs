﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace IntegraDesigner.Resources.Properties
{
    /// <summary>
    /// Interaction logic for VoiceMailMainProperty.xaml
    /// </summary>
    public partial class VoiceMailMainProperty : UserControl
    {
        VoiceMailMain v { get; set; }

        public VoiceMailMainProperty()
        {
            InitializeComponent();
        }

        public override string ToString()
        {
            v = (VoiceMailMain)base.Tag;

            Binding myBinding = new Binding("mailbox");
            myBinding.Mode = BindingMode.TwoWay;
            myBinding.Source = v;
            txtbox.SetBinding(TextBox.TextProperty, myBinding);

            Binding myBinding2 = new Binding("context");
            myBinding2.Mode = BindingMode.TwoWay;
            myBinding2.Source = v;
            txtcontext.SetBinding(TextBox.TextProperty, myBinding2);

            Binding myBinding3 = new Binding("options");
            myBinding3.Mode = BindingMode.TwoWay;
            myBinding3.Source = v;
            txtopts.SetBinding(TextBox.TextProperty, myBinding3);

            Binding descbinding = new Binding("Description");
            descbinding.Mode = BindingMode.TwoWay;
            descbinding.Source = v;
            txtdesc.SetBinding(TextBox.TextProperty, descbinding);


            return base.ToString();
        }
    }
}
