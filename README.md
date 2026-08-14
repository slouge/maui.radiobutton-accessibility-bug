# MAUI RadioButton Accessibility Bug - Reproduction Sample

This sample demonstrates a bug where RadioButton controls with custom ControlTemplates do not expose their checked state to Android's accessibility layer.

## Problem

When a RadioButton uses a custom ControlTemplate:
- ✅ The `IsChecked` property works correctly in C#
- ✅ The visual appearance updates via VisualStateManager
- ❌ **Android's AccessibilityService is not notified** - Appium/UIAutomator cannot detect the checked state