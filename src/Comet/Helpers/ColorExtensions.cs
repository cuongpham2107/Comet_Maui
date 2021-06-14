﻿using System;
using Microsoft.Maui.Graphics;


// ReSharper disable once CheckNamespace
namespace Comet
{
	public static class ColorExtensions
	{

		public static Color WithAlpha(this Color color, float alpha)
			=> new Color(color.Red, color.Green, color.Blue, alpha);

		/// <summary>
		/// Set the color
		/// </summary>
		/// <param name="view"></param>
		/// <param name="color"></param>
		/// <typeparam name="T"></typeparam>
		/// <returns></returns>
		public static T Color<T>(this T view, Color color) where T : View
		{
			view.SetEnvironment(EnvironmentKeys.Colors.Color, color, false);
			return view;
		}
		public static T Color<T>(this T view, Type type, Color color) where T : View
		{
			view.SetEnvironment(type, EnvironmentKeys.Colors.Color, color, true);
			return view;
		}

		public static Color GetColor<T>(this T view, Color defaultColor = null, ControlState state = ControlState.Default) where T : View
		{
			var color = view.GetEnvironment<Color>(EnvironmentKeys.Colors.Color,state);
			return color ?? defaultColor;
		}

		public static Color GetColor<T>(this T view, Type type, Color defaultColor = null) where T : View
		{
			var color = view.GetEnvironment<Color>(type, EnvironmentKeys.Colors.Color);
			return color ?? defaultColor;
		}

		public static Paint GetPaintColor<T>(this T view, Paint defaultColor = null, ControlState state = ControlState.Default) where T : View
		{
			var color = view.GetEnvironment<Paint>(EnvironmentKeys.Colors.Color, state);
			return color ?? defaultColor;
		}

		public static Paint GetPaintColor<T>(this T view, Type type, Paint defaultColor = null) where T : View
		{
			var color = view.GetEnvironment<Paint>(type, EnvironmentKeys.Colors.Color);
			return color ?? defaultColor;
		}

		/// <summary>
		/// Set the background color
		/// </summary>
		/// <param name="view"></param>
		/// <param name="color"></param>
		/// <typeparam name="T"></typeparam>
		/// <returns></returns>
		public static T Background<T>(this T view, Color color, bool cascades = false) where T : View
		{
			view.SetEnvironment(EnvironmentKeys.Colors.Background, new SolidPaint { Color = color, BackgroundColor = color }, cascades);
			return view;
		}

		/// <summary>
		/// Set the background color by hex value
		/// </summary>
		/// <param name="view"></param>
		/// <param name="colorHex"></param>
		/// <typeparam name="T"></typeparam>
		/// <returns></returns>
		public static T Background<T>(this T view, string colorHex, bool cascades = false) where T : View
		{
			var c = Microsoft.Maui.Graphics.Color.FromHex(colorHex);
			view.SetEnvironment(EnvironmentKeys.Colors.Background, new SolidPaint { Color = c, BackgroundColor =  c}, cascades);
			return view;
		}

		/// <summary>
		/// Set the background color
		/// </summary>
		/// <param name="view"></param>
		/// <param name="color"></param>
		/// <typeparam name="T"></typeparam>
		/// <returns></returns>
		public static T Background<T>(this T view, Type type, Color color) where T : View
		{
			view.SetEnvironment(type, EnvironmentKeys.Colors.Background, new SolidPaint { Color = color, BackgroundColor = color }, true);
			return view;
		}
		public static T Background<T>(this T view, Type type, Paint paint) where T : View
		{
			view.SetEnvironment(type, EnvironmentKeys.Colors.Background, paint, true);
			return view;
		}

		public static Paint GetBackground(this View view, Type type, Paint defaultColor = null, ControlState state = ControlState.Default)
		{
			var color = view?.GetEnvironment<Paint>(type, EnvironmentKeys.Colors.Background, state);
			return color ?? defaultColor;
		}

		public static Paint GetBackground(this View view, Paint defaultColor = null, ControlState state = ControlState.Default)
		{
			var color = view?.GetEnvironment<Paint>(EnvironmentKeys.Colors.Background,state);
			return color ?? defaultColor;
		}

		public static Color GetNavigationBackgroundColor(this View view, Color defaultColor = null)
		{
			var color = view.GetEnvironment<Color>(EnvironmentKeys.Navigation.BackgroundColor);
			return color ?? defaultColor;
		}
		public static Color GetNavigationTextColor(this View view, Color defaultColor = null)
		{
			var color = view.GetEnvironment<Color>(EnvironmentKeys.Navigation.TextColor);
			return color ?? defaultColor;
		}

		public static T TrackColor<T>(this T view, Color color, ControlState state = ControlState.Default) where T : Slider
		{
			view.SetEnvironment(EnvironmentKeys.Slider.TrackColor, color, cascades:false, state);
			return view;
		}

		public static Color GetTrackColor(this Slider view, Color defaultColor = null, ControlState state = ControlState.Default)
		{
			var color = view?.GetEnvironment<Color>(EnvironmentKeys.Slider.TrackColor, state);
			//Fall back to the default state before using the default color
			color ??= view?.GetEnvironment<Color>(EnvironmentKeys.Slider.TrackColor);
			return color ?? defaultColor;
		}

		public static T ProgressColor<T>(this T view, Color color, ControlState state = ControlState.Default) where T : Slider
		{
			view.SetEnvironment(EnvironmentKeys.Slider.ProgressColor, color, cascades:false, state);
			return view;
		}

		public static Color GetProgressColor(this Slider view, Color defaultColor = null, ControlState state = ControlState.Default)
		{
			var color = view?.GetEnvironment<Color>(EnvironmentKeys.Slider.ProgressColor, state);
			//Fall back to the default state before using the default color
			color ??= view?.GetEnvironment<Color>(EnvironmentKeys.Slider.ProgressColor);
			return color ?? defaultColor;
		}

		public static T ThumbColor<T>(this T view, Color color, ControlState state = ControlState.Default) where T : View, IThumbView
		{
			view.SetEnvironment(EnvironmentKeys.Slider.ThumbColor, color, cascades: false, state);
			return view;
		}

		public static Color GetThumbColor(this Slider view, Color defaultColor = null, ControlState state = ControlState.Default)
		{
			var color = view?.GetEnvironment<Color>(EnvironmentKeys.Slider.ThumbColor, state);
			//Fall back to the default state before using the default color
			color ??= view?.GetEnvironment<Color>(EnvironmentKeys.Slider.ThumbColor);
			return color ?? defaultColor;
		}

		public static Color GetThumbColor(this Toggle view, Color defaultColor = null, ControlState state = ControlState.Default)
		{
			var color = view?.GetEnvironment<Color>(EnvironmentKeys.Slider.ThumbColor, state);
			//Fall back to the default state before using the default color
			color ??= view?.GetEnvironment<Color>(EnvironmentKeys.Slider.ThumbColor);
			return color ?? defaultColor;
		}

		public static T TrackColor<T>(this T view, Color color, ControlState state = ControlState.Default, bool cascades = false)
			where T : ProgressBar
		{
			view.SetEnvironment(EnvironmentKeys.ProgressBar.TrackColor, color, cascades, state);
			return view;
		}

		public static Color GetTrackColor(this ProgressBar view, Color defaultColor = null, ControlState state = ControlState.Default)
		{
			var color = view?.GetEnvironment<Color>(EnvironmentKeys.ProgressBar.TrackColor, state);
			//Fall back to the default state before using the default color
			color ??= view?.GetEnvironment<Color>(EnvironmentKeys.ProgressBar.TrackColor);
			return color ?? defaultColor;
		}

		public static T ProgressColor<T>(this T view, Color color, bool cascades = false) where T : ProgressBar
		{
			view.SetEnvironment(EnvironmentKeys.ProgressBar.ProgressColor, color, cascades);
			return view;
		}

		public static Color GetProgressColor(this ProgressBar view, Color defaultColor = null, ControlState state = ControlState.Default)
		{
			var color = view?.GetEnvironment<Color>(EnvironmentKeys.ProgressBar.ProgressColor, state);
			//Fall back to the default state before using the default color
			color ??= view?.GetEnvironment<Color>(EnvironmentKeys.ProgressBar.ProgressColor);
			return color ?? defaultColor;
		}

		public static T Opacity<T>(this T view, double opacity, bool cascades = false) where T : View
		{
			view.SetEnvironment(EnvironmentKeys.View.Opacity, opacity, cascades);
			return view;
		}

		public static double GetOpacity(this View view, ControlState state = ControlState.Default)
		{
			var opacity = view?.GetEnvironment<double?>(EnvironmentKeys.View.Opacity, state);
			//Fall back to the default state before using the default color
			opacity ??= view?.GetEnvironment<double?>(EnvironmentKeys.View.Opacity);
			return opacity ?? 1;
		}


	}
}
