﻿////////////////////////////////////////////////////////////////////////////////////////////////////
// Noesis Engine - http://www.noesisengine.com
// Copyright (c) 2009-2010 Noesis Technologies S.L. All Rights Reserved.
////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Windows;
using System.Windows.Media;


namespace NoesisGUIExtensions
{

////////////////////////////////////////////////////////////////////////////////////////////////////
/// Provides a base class for projections, which describe how to transform an object
/// in 3-D space using perspective transforms.
////////////////////////////////////////////////////////////////////////////////////////////////////
public abstract class Projection : DependencyObject
{
}

////////////////////////////////////////////////////////////////////////////////////////////////////
/// Represents a perspective transform (a 3-D-like effect) on an object.
////////////////////////////////////////////////////////////////////////////////////////////////////
public class PlaneProjection : Projection
{
    /// <summary>
    /// Gets or sets the x-coordinate of the center of rotation of the object you rotate
    /// </summary>
    #region CenterOfRotationX dependency property

    public double CenterOfRotationX
    {
        get { return (double)GetValue(CenterOfRotationXProperty); }
        set { SetValue(CenterOfRotationXProperty, value); }
    }

    public static readonly DependencyProperty CenterOfRotationXProperty = 
        DependencyProperty.Register("CenterOfRotationX", typeof(double), typeof(PlaneProjection), new PropertyMetadata(0.0));

    #endregion

    /// <summary>
    /// Gets or sets the y-coordinate of the center of rotation of the object you rotate
    /// </summary>
    #region CenterOfRotationY dependency property

    public double CenterOfRotationY
    {
        get { return (double)GetValue(CenterOfRotationYProperty); }
        set { SetValue(CenterOfRotationYProperty, value); }
    }

    public static readonly DependencyProperty CenterOfRotationYProperty = 
        DependencyProperty.Register("CenterOfRotationY", typeof(double), typeof(PlaneProjection), new PropertyMetadata(0.0));

    #endregion

    /// <summary>
    /// Gets or sets the z-coordinate of the center of rotation of the object you rotate
    /// </summary>
    #region CenterOfRotationZ dependency property

    public double CenterOfRotationZ
    {
        get { return (double)GetValue(CenterOfRotationZProperty); }
        set { SetValue(CenterOfRotationZProperty, value); }
    }

    public static readonly DependencyProperty CenterOfRotationZProperty = 
        DependencyProperty.Register("CenterOfRotationZ", typeof(double), typeof(PlaneProjection), new PropertyMetadata(0.0));

    #endregion

    /// <summary>
    /// Gets or sets the distance the object is translated along the x-axis of the screen
    /// </summary>
    #region GlobalOffsetX dependency property

    public double GlobalOffsetX
    {
        get { return (double)GetValue(GlobalOffsetXProperty); }
        set { SetValue(GlobalOffsetXProperty, value); }
    }

    public static readonly DependencyProperty GlobalOffsetXProperty = 
        DependencyProperty.Register("GlobalOffsetX", typeof(double), typeof(PlaneProjection), new PropertyMetadata(0.0));

    #endregion

    /// <summary>
    /// Gets or sets the distance the object is translated along the y-axis of the screen
    /// </summary>
    #region GlobalOffsetY dependency property

    public double GlobalOffsetY
    {
        get { return (double)GetValue(GlobalOffsetYProperty); }
        set { SetValue(GlobalOffsetYProperty, value); }
    }

    public static readonly DependencyProperty GlobalOffsetYProperty = 
        DependencyProperty.Register("GlobalOffsetY", typeof(double), typeof(PlaneProjection), new PropertyMetadata(0.0));

    #endregion

    /// <summary>
    /// Gets or sets the distance the object is translated along the z-axis of the screen
    /// </summary>
    #region GlobalOffsetZ dependency property

    public double GlobalOffsetZ
    {
        get { return (double)GetValue(GlobalOffsetZProperty); }
        set { SetValue(GlobalOffsetZProperty, value); }
    }

    public static readonly DependencyProperty GlobalOffsetZProperty = 
        DependencyProperty.Register("GlobalOffsetZ", typeof(double), typeof(PlaneProjection), new PropertyMetadata(0.0));

    #endregion

    /// <summary>
    /// Gets or sets the distance the object is translated along the x-axis of the plane of the object
    /// </summary>
    #region LocalOffsetX dependency property

    public double LocalOffsetX
    {
        get { return (double)GetValue(LocalOffsetXProperty); }
        set { SetValue(LocalOffsetXProperty, value); }
    }

    public static readonly DependencyProperty LocalOffsetXProperty = 
        DependencyProperty.Register("LocalOffsetX", typeof(double), typeof(PlaneProjection), new PropertyMetadata(0.0));

    #endregion

    /// <summary>
    /// Gets or sets the distance the object is translated along the y-axis of the plane of the object
    /// </summary>
    #region LocalOffsetY dependency property

    public double LocalOffsetY
    {
        get { return (double)GetValue(LocalOffsetYProperty); }
        set { SetValue(LocalOffsetYProperty, value); }
    }

    public static readonly DependencyProperty LocalOffsetYProperty = 
        DependencyProperty.Register("LocalOffsetY", typeof(double), typeof(PlaneProjection), new PropertyMetadata(0.0));

    #endregion

    /// <summary>
    /// Gets or sets the distance the object is translated along the z-axis of the plane of the object
    /// </summary>
    #region LocalOffsetZ dependency property

    public double LocalOffsetZ
    {
        get { return (double)GetValue(LocalOffsetZProperty); }
        set { SetValue(LocalOffsetZProperty, value); }
    }

    public static readonly DependencyProperty LocalOffsetZProperty = 
        DependencyProperty.Register("LocalOffsetZ", typeof(double), typeof(PlaneProjection), new PropertyMetadata(0.0));

    #endregion

    /// <summary>
    /// Gets or sets the number of degrees to rotate the object around the x-axis of rotation
    /// </summary>
    #region RotationX dependency property

    public double RotationX
    {
        get { return (double)GetValue(RotationXProperty); }
        set { SetValue(RotationXProperty, value); }
    }

    public static readonly DependencyProperty RotationXProperty = 
        DependencyProperty.Register("RotationX", typeof(double), typeof(PlaneProjection), new PropertyMetadata(0.0));

    #endregion

    /// <summary>
    /// Gets or sets the number of degrees to rotate the object around the y-axis of rotation
    /// </summary>
    #region RotationY dependency property

    public double RotationY
    {
        get { return (double)GetValue(RotationYProperty); }
        set { SetValue(RotationYProperty, value); }
    }

    public static readonly DependencyProperty RotationYProperty = 
        DependencyProperty.Register("RotationY", typeof(double), typeof(PlaneProjection), new PropertyMetadata(0.0));

    #endregion

    /// <summary>
    /// Gets or sets the number of degrees to rotate the object around the z-axis of rotation
    /// </summary>
    #region RotationZ dependency property

    public double RotationZ
    {
        get { return (double)GetValue(RotationZProperty); }
        set { SetValue(RotationZProperty, value); }
    }

    public static readonly DependencyProperty RotationZProperty = 
        DependencyProperty.Register("RotationZ", typeof(double), typeof(PlaneProjection), new PropertyMetadata(0.0));

    #endregion
}

////////////////////////////////////////////////////////////////////////////////////////////////////
/// Adds projection capabilities to UI elements.
///
/// Usage:
///
///     <Grid
///       xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
///       xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
///       xmlns:noesis="clr-namespace:NoesisGUIExtensions">
///         <Grid.Resources>
///             <Storyboard x:Key="AnimProjection" AutoReverse="True" RepeatBehavior="Forever">
///                 <DoubleAnimationUsingKeyFrames
///                   Storyboard.TargetProperty="(noesis:Element.Projection).(noesis:PlaneProjection.RotationY)"
///                   Storyboard.TargetName="Root">
///                     <EasingDoubleKeyFrame KeyTime="0:0:2" Value="-60">
///                         <EasingDoubleKeyFrame.EasingFunction>
///                             <SineEase EasingMode="EaseInOut"/>
///                         </EasingDoubleKeyFrame.EasingFunction>
///                     </EasingDoubleKeyFrame>
///                 </DoubleAnimationUsingKeyFrames>
///             </Storyboard>
///         </Grid.Resources>
///         <Grid.Triggers>
///             <EventTrigger RoutedEvent="FrameworkElement.Loaded">
///                 <BeginStoryboard Storyboard="{StaticResource AnimProjection}"/>
///             </EventTrigger>
///         </Grid.Triggers>
///         <Grid x:Name="Root">
///             <noesis:Element.Projection>
///                 <noesis:PlaneProjection RotationY="60"/>
///             </noesis:Element.Projection>
///             <Rectangle Width="500" Height="300" Fill="#80FF0000"/>
///             <TextBlock
///               Text="3D Projection, wow!"
///               FontSize="40"
///               HorizontalAlignment="Center"
///               VerticalAlignment="Center"/>
///         </Grid>
///     </Grid>
///
////////////////////////////////////////////////////////////////////////////////////////////////////
public class Element
{
    public Element()
    {
    }

    /// <summary>
    /// Specifies the Projection object used to project the UI element
    /// </summary>
    #region Projection attached property

    public static readonly DependencyProperty ProjectionProperty =
        DependencyProperty.RegisterAttached("Projection", typeof(Projection), typeof(Element),
        new PropertyMetadata(null));

    public static void SetProjection(UIElement element, Projection value)
    {
        element.SetValue(ProjectionProperty, value);
    }

    public static Projection GetProjection(UIElement element)
    {
        return (Projection)element.GetValue(ProjectionProperty);
    }

    #endregion
}

}
