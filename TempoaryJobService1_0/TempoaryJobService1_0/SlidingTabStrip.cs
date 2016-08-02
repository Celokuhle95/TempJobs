/**using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Graphics;
using Android.Util;

namespace TempoaryJobService1_0
{
    class SlidingTabStrip : LinearLayout
    {
        private const int DEFAULT_BOTTOM_BORDER_THICKNESS_DISPS = 2;
        private const byte DEFAULT_BOTTOM_BORDER_COLOR_ALPHA = 0x26;
        private const int SELECTED_INDICATOR_THICKNESS_DIPS = 8;
        private int[] INDICATOR_COLORS = { 0x19A319, 0x0000FC };
        private int[] DIVIDER_COLORS = { 0xC5C5C5 };

        private const int DEFAULT_DEVIDER_THICKNESS_DISPS = 1;
        private const float DEFAULT_DIVIDER_HEIGHT = 0.5f;

        private int mBottomBorderThickness;
        private Paint mBottomBorderPaint;
        private int mDefaultBottomBorderColor;


        private int mSelectedIndicatorThickness;
        private Paint mSelectedIndicatorPaint;

        private Paint mDividerPaint;
        private float mDividerHeight;

        private int mSelectedPosition;
        private float mSelectionOffset;

        private SlidingTabScrollView.TabColorizer mCustomTabColorizer;
        private SimpleTabColorizer mDefaultTabColorizer;


        private SlidingTabStrip(Context context) : this(context, null)
        {

        }

        public SlidingTabStrip (Context context, IAttributeSet attrs) : base(context, attrs)
        {
            SetWillNotDraw(false);

            float density = Resources.DisplayMetrics.Density;

            TypedValue outValue = new TypedValue();
            context.Theme.ResolveAttribute(Android.Resource.Attribute.ColorForeground, outValue, true);
            int themeForeGround = outValue.Data;
            mDefaultBottomBorderColor = SetColorAlpha(themeForeGround, DEFAULT_BOTTOM_BORDER_COLOR_ALPHA);

            mDefaultTabColorizer = new SimpleTabColorizer();
            mDefaultTabColorizer.SetIndicatorColor(INDICATOR_COLORS);
            mDefaultTabColorizer.SetDividerColors(DIVIDER_COLORS);


        }

        private int SetColorAlpha(int themeForeGround, byte dEFAULT_BOTTOM_BORDER_COLOR_ALPHA)
        {
            throw new NotImplementedException();
        }

        private class SimpleTabColorizer : SlidingTabScrollView.TabColorizer
        {
            private int[] mIndicatorColors;
            private int[] mDividerColors;

            public int GetIndicatorColor(int position)
            {
                return mIndicatorColors[position % mIndicatorColors.Length];
            }

            public int GetdividerColors (int position)
            {
                return mDividerColors[position % mDividerColors.Length];
            }
        }
    }
}**/