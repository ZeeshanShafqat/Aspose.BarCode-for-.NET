﻿//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2015 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.BarCode. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System.IO;

using Aspose.BarCode;
using System;

namespace CSharp.Programming_BarCode
{
    class BarcodeCaption
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ProgrammingBarCode();
            string dst = dataDir + "barcode-caption.jpg";

            //Instantiate barcode object
            BarCodeBuilder bb = new BarCodeBuilder();

            //Set the Code text for the barcode
            bb.CodeText = "1234567";

            //Set the symbology type to Code128
            bb.SymbologyType = Symbology.Code128;

            bb.CaptionAbove.Visible = false;

            //Create caption object. Set its text and text alignment & also make it visible
            Caption caption = new Caption();
            caption.Text = "Aspose";
            caption.TextAlign = System.Drawing.StringAlignment.Center;
            caption.Visible = true;
            caption.Font = new System.Drawing.Font("Pristina", 14f);
            caption.ForeColor = System.Drawing.Color.Red;

            //Assign caption object to be displayed above the barcode
            bb.CaptionAbove = caption;

            Caption captionBelow = new Caption();
            captionBelow.Text = "Aspose.BarCode Caption Below";
            captionBelow.TextAlign = System.Drawing.StringAlignment.Center;
            captionBelow.Visible = true;
            captionBelow.Font = new System.Drawing.Font("Pristina", 14f);
            captionBelow.ForeColor = System.Drawing.Color.OrangeRed;

            //Assign caption object to be displayed below the barcode
            bb.CaptionBelow = captionBelow;

            //Save the image to your system and set its image format to Jpeg
            bb.Save(dst, System.Drawing.Imaging.ImageFormat.Jpeg);

            Console.WriteLine(Environment.NewLine + "Barcode saved at " + dst);
        }
    }
}
