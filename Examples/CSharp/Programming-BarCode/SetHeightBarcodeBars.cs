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
    class SetHeightBarcodeBars
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ProgrammingBarCode();
            string dst = dataDir + "Code128-bar-height.png";

            //Instantiate barcode object
            BarCodeBuilder lbc = new BarCodeBuilder();

            //Set the Code text for the barcode
            lbc.CodeText = "1234567";

            //Set the symbology type to Code128
            lbc.SymbologyType = Symbology.Code128;

            //Set the bar height to 3 millimeters
            lbc.BarHeight = 3.0f;

            //Set the measuring unit of barcode to millimeter
            lbc.GraphicsUnit = System.Drawing.GraphicsUnit.Millimeter;

            //Save the image locally and set its image format to Jpeg
            lbc.Save(dataDir + "barcode3.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);

            //Set the bar height to 3 millimeters
            lbc.BarHeight = 7.0f;

            //Save the image locally and set its image format to Jpeg
            lbc.Save(dataDir + "barcode7.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);

            //Set the bar height to 3 millimeters
            lbc.BarHeight = 11.0f;

            //Save the image locally and set its image format to Jpeg
            lbc.Save(dst, System.Drawing.Imaging.ImageFormat.Jpeg);

            Console.WriteLine(Environment.NewLine + "Barcode saved at " + dst);
        }
    }
}
