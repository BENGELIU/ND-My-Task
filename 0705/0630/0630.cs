//
// File generated by HDevelop for HALCON/.NET (C#) Version 18.11.1.1
// Non-ASCII strings in this file are encoded in local-8-bit encoding (cp936).
// 
// Please note that non-ASCII characters in string constants are exported
// as octal codes in order to guarantee that the strings are correctly
// created on all systems, independent on any compiler settings.
// 
// Source files with different encoding should not be mixed in one project.
//
//  This file is intended to be used with the HDevelopTemplate or
//  HDevelopTemplateWPF projects located under %HALCONEXAMPLES%\c#

using System;
using HalconDotNet;

public partial class HDevelopExport
{
  public HTuple hv_ExpDefaultWinHandle;

  // Procedures 
  // Chapter: Graphics / Text
  // Short Description: This procedure writes a text message. 
  public void disp_message (HTuple hv_WindowHandle, HTuple hv_String, HTuple hv_CoordSystem, 
      HTuple hv_Row, HTuple hv_Column, HTuple hv_Color, HTuple hv_Box)
  {



    // Local iconic variables 

    // Local control variables 

    HTuple hv_GenParamName = new HTuple(), hv_GenParamValue = new HTuple();
    HTuple   hv_Color_COPY_INP_TMP = new HTuple(hv_Color);
    HTuple   hv_Column_COPY_INP_TMP = new HTuple(hv_Column);
    HTuple   hv_CoordSystem_COPY_INP_TMP = new HTuple(hv_CoordSystem);
    HTuple   hv_Row_COPY_INP_TMP = new HTuple(hv_Row);

    // Initialize local and output iconic variables 
    //This procedure displays text in a graphics window.
    //
    //Input parameters:
    //WindowHandle: The WindowHandle of the graphics window, where
    //   the message should be displayed
    //String: A tuple of strings containing the text message to be displayed
    //CoordSystem: If set to 'window', the text position is given
    //   with respect to the window coordinate system.
    //   If set to 'image', image coordinates are used.
    //   (This may be useful in zoomed images.)
    //Row: The row coordinate of the desired text position
    //   A tuple of values is allowed to display text at different
    //   positions.
    //Column: The column coordinate of the desired text position
    //   A tuple of values is allowed to display text at different
    //   positions.
    //Color: defines the color of the text as string.
    //   If set to [], '' or 'auto' the currently set color is used.
    //   If a tuple of strings is passed, the colors are used cyclically...
    //   - if |Row| == |Column| == 1: for each new textline
    //   = else for each text position.
    //Box: If Box[0] is set to 'true', the text is written within an orange box.
    //     If set to' false', no box is displayed.
    //     If set to a color string (e.g. 'white', '#FF00CC', etc.),
    //       the text is written in a box of that color.
    //     An optional second value for Box (Box[1]) controls if a shadow is displayed:
    //       'true' -> display a shadow in a default color
    //       'false' -> display no shadow
    //       otherwise -> use given string as color string for the shadow color
    //
    //It is possible to display multiple text strings in a single call.
    //In this case, some restrictions apply:
    //- Multiple text positions can be defined by specifying a tuple
    //  with multiple Row and/or Column coordinates, i.e.:
    //  - |Row| == n, |Column| == n
    //  - |Row| == n, |Column| == 1
    //  - |Row| == 1, |Column| == n
    //- If |Row| == |Column| == 1,
    //  each element of String is display in a new textline.
    //- If multiple positions or specified, the number of Strings
    //  must match the number of positions, i.e.:
    //  - Either |String| == n (each string is displayed at the
    //                          corresponding position),
    //  - or     |String| == 1 (The string is displayed n times).
    //
    //
    //Convert the parameters for disp_text.
    if ((int)((new HTuple(hv_Row_COPY_INP_TMP.TupleEqual(new HTuple()))).TupleOr(
        new HTuple(hv_Column_COPY_INP_TMP.TupleEqual(new HTuple())))) != 0)
    {

      hv_Color_COPY_INP_TMP.Dispose();
      hv_Column_COPY_INP_TMP.Dispose();
      hv_CoordSystem_COPY_INP_TMP.Dispose();
      hv_Row_COPY_INP_TMP.Dispose();
      hv_GenParamName.Dispose();
      hv_GenParamValue.Dispose();

      return;
    }
    if ((int)(new HTuple(hv_Row_COPY_INP_TMP.TupleEqual(-1))) != 0)
    {
      hv_Row_COPY_INP_TMP.Dispose();
      hv_Row_COPY_INP_TMP = 12;
    }
    if ((int)(new HTuple(hv_Column_COPY_INP_TMP.TupleEqual(-1))) != 0)
    {
      hv_Column_COPY_INP_TMP.Dispose();
      hv_Column_COPY_INP_TMP = 12;
    }
    //
    //Convert the parameter Box to generic parameters.
    hv_GenParamName.Dispose();
    hv_GenParamName = new HTuple();
    hv_GenParamValue.Dispose();
    hv_GenParamValue = new HTuple();
    if ((int)(new HTuple((new HTuple(hv_Box.TupleLength())).TupleGreater(0))) != 0)
    {
      if ((int)(new HTuple(((hv_Box.TupleSelect(0))).TupleEqual("false"))) != 0)
      {
        //Display no box
        using (HDevDisposeHelper dh = new HDevDisposeHelper())
        {
        {
        HTuple 
          ExpTmpLocalVar_GenParamName = hv_GenParamName.TupleConcat(
            "box");
        hv_GenParamName.Dispose();
        hv_GenParamName = ExpTmpLocalVar_GenParamName;
        }
        }
        using (HDevDisposeHelper dh = new HDevDisposeHelper())
        {
        {
        HTuple 
          ExpTmpLocalVar_GenParamValue = hv_GenParamValue.TupleConcat(
            "false");
        hv_GenParamValue.Dispose();
        hv_GenParamValue = ExpTmpLocalVar_GenParamValue;
        }
        }
      }
      else if ((int)(new HTuple(((hv_Box.TupleSelect(0))).TupleNotEqual("true"))) != 0)
      {
        //Set a color other than the default.
        using (HDevDisposeHelper dh = new HDevDisposeHelper())
        {
        {
        HTuple 
          ExpTmpLocalVar_GenParamName = hv_GenParamName.TupleConcat(
            "box_color");
        hv_GenParamName.Dispose();
        hv_GenParamName = ExpTmpLocalVar_GenParamName;
        }
        }
        using (HDevDisposeHelper dh = new HDevDisposeHelper())
        {
        {
        HTuple 
          ExpTmpLocalVar_GenParamValue = hv_GenParamValue.TupleConcat(
            hv_Box.TupleSelect(0));
        hv_GenParamValue.Dispose();
        hv_GenParamValue = ExpTmpLocalVar_GenParamValue;
        }
        }
      }
    }
    if ((int)(new HTuple((new HTuple(hv_Box.TupleLength())).TupleGreater(1))) != 0)
    {
      if ((int)(new HTuple(((hv_Box.TupleSelect(1))).TupleEqual("false"))) != 0)
      {
        //Display no shadow.
        using (HDevDisposeHelper dh = new HDevDisposeHelper())
        {
        {
        HTuple 
          ExpTmpLocalVar_GenParamName = hv_GenParamName.TupleConcat(
            "shadow");
        hv_GenParamName.Dispose();
        hv_GenParamName = ExpTmpLocalVar_GenParamName;
        }
        }
        using (HDevDisposeHelper dh = new HDevDisposeHelper())
        {
        {
        HTuple 
          ExpTmpLocalVar_GenParamValue = hv_GenParamValue.TupleConcat(
            "false");
        hv_GenParamValue.Dispose();
        hv_GenParamValue = ExpTmpLocalVar_GenParamValue;
        }
        }
      }
      else if ((int)(new HTuple(((hv_Box.TupleSelect(1))).TupleNotEqual("true"))) != 0)
      {
        //Set a shadow color other than the default.
        using (HDevDisposeHelper dh = new HDevDisposeHelper())
        {
        {
        HTuple 
          ExpTmpLocalVar_GenParamName = hv_GenParamName.TupleConcat(
            "shadow_color");
        hv_GenParamName.Dispose();
        hv_GenParamName = ExpTmpLocalVar_GenParamName;
        }
        }
        using (HDevDisposeHelper dh = new HDevDisposeHelper())
        {
        {
        HTuple 
          ExpTmpLocalVar_GenParamValue = hv_GenParamValue.TupleConcat(
            hv_Box.TupleSelect(1));
        hv_GenParamValue.Dispose();
        hv_GenParamValue = ExpTmpLocalVar_GenParamValue;
        }
        }
      }
    }
    //Restore default CoordSystem behavior.
    if ((int)(new HTuple(hv_CoordSystem_COPY_INP_TMP.TupleNotEqual("window"))) != 0)
    {
      hv_CoordSystem_COPY_INP_TMP.Dispose();
      hv_CoordSystem_COPY_INP_TMP = "image";
    }
    //
    if ((int)(new HTuple(hv_Color_COPY_INP_TMP.TupleEqual(""))) != 0)
    {
      //disp_text does not accept an empty string for Color.
      hv_Color_COPY_INP_TMP.Dispose();
      hv_Color_COPY_INP_TMP = new HTuple();
    }
    //
    HOperatorSet.DispText(hv_ExpDefaultWinHandle, hv_String, hv_CoordSystem_COPY_INP_TMP, 
        hv_Row_COPY_INP_TMP, hv_Column_COPY_INP_TMP, hv_Color_COPY_INP_TMP, hv_GenParamName, 
        hv_GenParamValue);

    hv_Color_COPY_INP_TMP.Dispose();
    hv_Column_COPY_INP_TMP.Dispose();
    hv_CoordSystem_COPY_INP_TMP.Dispose();
    hv_Row_COPY_INP_TMP.Dispose();
    hv_GenParamName.Dispose();
    hv_GenParamValue.Dispose();

    return;
  }

  // Main procedure 
  private void action()
  {


    // Local iconic variables 

    HObject ho_Image2, ho_Region, ho_ConnectedRegions;
    HObject ho_SelectedRegions;

    // Local control variables 

    HTuple hv_Width = new HTuple(), hv_Height = new HTuple();
    HTuple hv_WindowHandle = new HTuple(), hv_Area = new HTuple();
    HTuple hv_Row = new HTuple(), hv_Column = new HTuple();
    // Initialize local and output iconic variables 
    HOperatorSet.GenEmptyObj(out ho_Image2);
    HOperatorSet.GenEmptyObj(out ho_Region);
    HOperatorSet.GenEmptyObj(out ho_ConnectedRegions);
    HOperatorSet.GenEmptyObj(out ho_SelectedRegions);
    HOperatorSet.ClearWindow(hv_ExpDefaultWinHandle);
    ho_Image2.Dispose();
    HOperatorSet.ReadImage(out ho_Image2, "E:/����/0630/0630vs/0630vs/bin/2.bmp");
    hv_Width.Dispose();hv_Height.Dispose();
    HOperatorSet.GetImageSize(ho_Image2, out hv_Width, out hv_Height);
    //dev_open_window(...);
    HOperatorSet.DispObj(ho_Image2, hv_ExpDefaultWinHandle);

    ho_Region.Dispose();
    HOperatorSet.Threshold(ho_Image2, out ho_Region, 0, 100);
    ho_ConnectedRegions.Dispose();
    HOperatorSet.Connection(ho_Region, out ho_ConnectedRegions);

    ho_SelectedRegions.Dispose();
    HOperatorSet.SelectShape(ho_ConnectedRegions, out ho_SelectedRegions, "area", 
        "and", 0, 10000);

    hv_Area.Dispose();hv_Row.Dispose();hv_Column.Dispose();
    HOperatorSet.AreaCenter(ho_SelectedRegions, out hv_Area, out hv_Row, out hv_Column);

    HOperatorSet.ClearWindow(hv_ExpDefaultWinHandle);
    HOperatorSet.DispObj(ho_Image2, hv_ExpDefaultWinHandle);

    disp_message(hv_ExpDefaultWinHandle, hv_Area, "window", hv_Row, hv_Column, "black", 
        "true");
    ho_Image2.Dispose();
    ho_Region.Dispose();
    ho_ConnectedRegions.Dispose();
    ho_SelectedRegions.Dispose();

    hv_Width.Dispose();
    hv_Height.Dispose();
    hv_WindowHandle.Dispose();
    hv_Area.Dispose();
    hv_Row.Dispose();
    hv_Column.Dispose();

  }

  public void InitHalcon()
  {
    // Default settings used in HDevelop
    HOperatorSet.SetSystem("width", 512);
    HOperatorSet.SetSystem("height", 512);
  }

  public void RunHalcon(HTuple Window)
  {
    hv_ExpDefaultWinHandle = Window;
    action();
  }

}

