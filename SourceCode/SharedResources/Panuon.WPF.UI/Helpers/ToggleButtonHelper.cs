﻿using Panuon.WPF.UI.Internal;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Media;

namespace Panuon.WPF.UI
{
    public static class ToggleButtonHelper
    {
        #region ComponentResourceKeys
        public static ComponentResourceKey PendingSpinStyle { get; } =
            new ComponentResourceKey(typeof(ToggleButtonHelper), nameof(PendingSpinStyle));
        #endregion

        #region Properties

        #region Icon
        public static object GetIcon(ToggleButton toggleButton)
        {
            return (object)toggleButton.GetValue(IconProperty);
        }

        public static void SetIcon(ToggleButton toggleButton, object value)
        {
            toggleButton.SetValue(IconProperty, value);
        }

        public static readonly DependencyProperty IconProperty =
            DependencyProperty.RegisterAttached("Icon", typeof(object), typeof(ToggleButtonHelper));
        #endregion

        #region CheckedIcon
        public static object GetCheckedIcon(ToggleButton toggleButton)
        {
            return (object)toggleButton.GetValue(CheckedIconProperty);
        }

        public static void SetCheckedIcon(ToggleButton toggleButton, object value)
        {
            toggleButton.SetValue(CheckedIconProperty, value);
        }

        public static readonly DependencyProperty CheckedIconProperty =
            DependencyProperty.RegisterAttached("CheckedIcon", typeof(object), typeof(ToggleButtonHelper));
        #endregion

        #region IconPlacement
        public static IconPlacement GetIconPlacement(ToggleButton toggleButton)
        {
            return (IconPlacement)toggleButton.GetValue(IconPlacementProperty);
        }

        public static void SetIconPlacement(ToggleButton toggleButton, IconPlacement value)
        {
            toggleButton.SetValue(IconPlacementProperty, value);
        }

        public static readonly DependencyProperty IconPlacementProperty =
            DependencyProperty.RegisterAttached("IconPlacement", typeof(IconPlacement), typeof(ToggleButtonHelper));
        #endregion

        #region CornerRadius
        public static CornerRadius GetCornerRadius(ToggleButton toggleButton)
        {
            return (CornerRadius)toggleButton.GetValue(CornerRadiusProperty);
        }

        public static void SetCornerRadius(ToggleButton toggleButton, CornerRadius value)
        {
            toggleButton.SetValue(CornerRadiusProperty, value);
        }

        public static readonly DependencyProperty CornerRadiusProperty =
            DependencyProperty.RegisterAttached("CornerRadius", typeof(CornerRadius), typeof(ToggleButtonHelper));
        #endregion

        #region IsPending
        public static bool GetIsPending(ToggleButton toggleButton)
        {
            return (bool)toggleButton.GetValue(IsPendingProperty);
        }

        public static void SetIsPending(ToggleButton toggleButton, bool value)
        {
            toggleButton.SetValue(IsPendingProperty, value);
        }

        public static readonly DependencyProperty IsPendingProperty =
            DependencyProperty.RegisterAttached("IsPending", typeof(bool), typeof(ToggleButtonHelper));
        #endregion

        #region PendingSpinStyle
        public static Style GetPendingSpinStyle(ToggleButton toggleButton)
        {
            return (Style)toggleButton.GetValue(PendingSpinStyleProperty);
        }

        public static void SetPendingSpinStyle(ToggleButton toggleButton, Style value)
        {
            toggleButton.SetValue(PendingSpinStyleProperty, value);
        }

        public static readonly DependencyProperty PendingSpinStyleProperty =
            DependencyProperty.RegisterAttached("PendingSpinStyle", typeof(Style), typeof(ToggleButtonHelper));
        #endregion

        #region ShadowColor
        public static Color? GetShadowColor(ToggleButton toggleButton)
        {
            return (Color?)toggleButton.GetValue(ShadowColorProperty);
        }

        public static void SetShadowColor(ToggleButton toggleButton, Color? value)
        {
            toggleButton.SetValue(ShadowColorProperty, value);
        }

        public static readonly DependencyProperty ShadowColorProperty =
            VisualStateHelper.ShadowColorProperty.AddOwner(typeof(ToggleButtonHelper));
        #endregion

        #region HoverBackground
        public static Brush GetHoverBackground(ToggleButton toggleButton)
        {
            return (Brush)toggleButton.GetValue(HoverBackgroundProperty);
        }

        public static void SetHoverBackground(ToggleButton toggleButton, Brush value)
        {
            toggleButton.SetValue(HoverBackgroundProperty, value);
        }

        public static readonly DependencyProperty HoverBackgroundProperty =
            VisualStateHelper.HoverBackgroundProperty.AddOwner(typeof(ToggleButtonHelper));
        #endregion

        #region HoverForeground
        public static Brush GetHoverForeground(ToggleButton toggleButton)
        {
            return (Brush)toggleButton.GetValue(HoverForegroundProperty);
        }

        public static void SetHoverForeground(ToggleButton toggleButton, Brush value)
        {
            toggleButton.SetValue(HoverForegroundProperty, value);
        }

        public static readonly DependencyProperty HoverForegroundProperty =
            VisualStateHelper.HoverForegroundProperty.AddOwner(typeof(ToggleButtonHelper));
        #endregion

        #region HoverBorderBrush
        public static Brush GetHoverBorderBrush(ToggleButton toggleButton)
        {
            return (Brush)toggleButton.GetValue(HoverBorderBrushProperty);
        }

        public static void SetHoverBorderBrush(ToggleButton toggleButton, Brush value)
        {
            toggleButton.SetValue(HoverBorderBrushProperty, value);
        }

        public static readonly DependencyProperty HoverBorderBrushProperty =
            VisualStateHelper.HoverBorderBrushProperty.AddOwner(typeof(ToggleButtonHelper));
        #endregion

        #region HoverBorderThickness
        public static Thickness? GetHoverBorderThickness(ToggleButton toggleButton)
        {
            return (Thickness?)toggleButton.GetValue(HoverBorderThicknessProperty);
        }

        public static void SetHoverBorderThickness(ToggleButton toggleButton, Thickness? value)
        {
            toggleButton.SetValue(HoverBorderThicknessProperty, value);
        }

        public static readonly DependencyProperty HoverBorderThicknessProperty =
            VisualStateHelper.HoverBorderThicknessProperty.AddOwner(typeof(ToggleButtonHelper));
        #endregion

        #region HoverCornerRadius
        public static CornerRadius? GetHoverCornerRadius(ToggleButton toggleButton)
        {
            return (CornerRadius?)toggleButton.GetValue(HoverCornerRadiusProperty);
        }

        public static void SetHoverCornerRadius(ToggleButton toggleButton, CornerRadius? value)
        {
            toggleButton.SetValue(HoverCornerRadiusProperty, value);
        }

        public static readonly DependencyProperty HoverCornerRadiusProperty =
            VisualStateHelper.HoverCornerRadiusProperty.AddOwner(typeof(ToggleButtonHelper));
        #endregion

        #region HoverShadowColor
        public static Color? GetHoverShadowColor(ToggleButton toggleButton)
        {
            return (Color?)toggleButton.GetValue(HoverShadowColorProperty);
        }

        public static void SetHoverShadowColor(ToggleButton toggleButton, Color? value)
        {
            toggleButton.SetValue(HoverShadowColorProperty, value);
        }
        public static readonly DependencyProperty HoverShadowColorProperty =
            VisualStateHelper.HoverShadowColorProperty.AddOwner(typeof(ToggleButtonHelper));
        #endregion

        #region CheckedBackground
        public static Brush GetCheckedBackground(ToggleButton toggleButton)
        {
            return (Brush)toggleButton.GetValue(CheckedBackgroundProperty);
        }

        public static void SetCheckedBackground(ToggleButton toggleButton, Brush value)
        {
            toggleButton.SetValue(CheckedBackgroundProperty, value);
        }

        public static readonly DependencyProperty CheckedBackgroundProperty =
            DependencyProperty.RegisterAttached("CheckedBackground", typeof(Brush), typeof(ToggleButtonHelper));
        #endregion

        #region CheckedForeground
        public static Brush GetCheckedForeground(ToggleButton toggleButton)
        {
            return (Brush)toggleButton.GetValue(CheckedForegroundProperty);
        }

        public static void SetCheckedForeground(ToggleButton toggleButton, Brush value)
        {
            toggleButton.SetValue(CheckedForegroundProperty, value);
        }

        public static readonly DependencyProperty CheckedForegroundProperty =
            DependencyProperty.RegisterAttached("CheckedForeground", typeof(Brush), typeof(ToggleButtonHelper));
        #endregion

        #region CheckedBorderBrush
        public static Brush GetCheckedBorderBrush(ToggleButton toggleButton)
        {
            return (Brush)toggleButton.GetValue(CheckedBorderBrushProperty);
        }

        public static void SetCheckedBorderBrush(ToggleButton toggleButton, Brush value)
        {
            toggleButton.SetValue(CheckedBorderBrushProperty, value);
        }

        public static readonly DependencyProperty CheckedBorderBrushProperty =
            DependencyProperty.RegisterAttached("CheckedBorderBrush", typeof(Brush), typeof(ToggleButtonHelper));
        #endregion

        #region CheckedBorderThickness
        public static Thickness? GetCheckedBorderThickness(ToggleButton toggleButton)
        {
            return (Thickness?)toggleButton.GetValue(CheckedBorderThicknessProperty);
        }

        public static void SetCheckedBorderThickness(ToggleButton toggleButton, Thickness? value)
        {
            toggleButton.SetValue(CheckedBorderThicknessProperty, value);
        }

        public static readonly DependencyProperty CheckedBorderThicknessProperty =
            DependencyProperty.RegisterAttached("CheckedBorderThickness", typeof(Thickness?), typeof(ToggleButtonHelper));
        #endregion

        #region CheckedShadowColor
        public static Color? GetCheckedShadowColor(ToggleButton toggleButton)
        {
            return (Color?)toggleButton.GetValue(CheckedShadowColorProperty);
        }

        public static void SetCheckedShadowColor(ToggleButton toggleButton, Color? value)
        {
            toggleButton.SetValue(CheckedShadowColorProperty, value);
        }
        public static readonly DependencyProperty CheckedShadowColorProperty =
            VisualStateHelper.CheckedShadowColorProperty.AddOwner(typeof(ToggleButtonHelper));
        #endregion

        #region CheckedContent
        public static object GetCheckedContent(ToggleButton toggleButton)
        {
            return (object)toggleButton.GetValue(CheckedContentProperty);
        }

        public static void SetCheckedContent(ToggleButton toggleButton, object value)
        {
            toggleButton.SetValue(CheckedContentProperty, value);
        }

        public static readonly DependencyProperty CheckedContentProperty =
            DependencyProperty.RegisterAttached("CheckedContent", typeof(object), typeof(ToggleButtonHelper));
        #endregion

        #region ClickBackground
        public static Brush GetClickBackground(ToggleButton toggleButton)
        {
            return (Brush)toggleButton.GetValue(ClickBackgroundProperty);
        }

        public static void SetClickBackground(ToggleButton toggleButton, Brush value)
        {
            toggleButton.SetValue(ClickBackgroundProperty, value);
        }

        public static readonly DependencyProperty ClickBackgroundProperty =
            DependencyProperty.RegisterAttached("ClickBackground", typeof(Brush), typeof(ToggleButtonHelper));
        #endregion

        #region ClickForeground
        public static Brush GetClickForeground(ToggleButton toggleButton)
        {
            return (Brush)toggleButton.GetValue(ClickForegroundProperty);
        }

        public static void SetClickForeground(ToggleButton toggleButton, Brush value)
        {
            toggleButton.SetValue(ClickForegroundProperty, value);
        }

        public static readonly DependencyProperty ClickForegroundProperty =
            DependencyProperty.RegisterAttached("ClickForeground", typeof(Brush), typeof(ToggleButtonHelper));
        #endregion

        #region ClickBorderBrush
        public static Brush GetClickBorderBrush(ToggleButton toggleButton)
        {
            return (Brush)toggleButton.GetValue(ClickBorderBrushProperty);
        }

        public static void SetClickBorderBrush(ToggleButton toggleButton, Brush value)
        {
            toggleButton.SetValue(ClickBorderBrushProperty, value);
        }

        public static readonly DependencyProperty ClickBorderBrushProperty =
            DependencyProperty.RegisterAttached("ClickBorderBrush", typeof(Brush), typeof(ToggleButtonHelper));
        #endregion

        #region ClickBorderThickness
        public static Thickness? GetClickBorderThickness(ToggleButton toggleButton)
        {
            return (Thickness?)toggleButton.GetValue(ClickBorderThicknessProperty);
        }

        public static void SetClickBorderThickness(ToggleButton toggleButton, Thickness? value)
        {
            toggleButton.SetValue(ClickBorderThicknessProperty, value);
        }

        public static readonly DependencyProperty ClickBorderThicknessProperty =
            DependencyProperty.RegisterAttached("ClickBorderThickness", typeof(Thickness?), typeof(ToggleButtonHelper));
        #endregion

        #region ClickCornerRadius
        public static CornerRadius? GetClickCornerRadius(ToggleButton toggleButton)
        {
            return (CornerRadius?)toggleButton.GetValue(ClickCornerRadiusProperty);
        }

        public static void SetClickCornerRadius(ToggleButton toggleButton, CornerRadius? value)
        {
            toggleButton.SetValue(ClickCornerRadiusProperty, value);
        }

        public static readonly DependencyProperty ClickCornerRadiusProperty =
            DependencyProperty.RegisterAttached("ClickCornerRadius", typeof(CornerRadius?), typeof(ToggleButtonHelper));
        #endregion

        #endregion
    }
}
