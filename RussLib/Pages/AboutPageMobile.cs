using BasecodeLibrary.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace RussLib.Pages
{
    [TemplatePart(Name = "PART_Photo", Type = typeof(Image))]
    [TemplatePart(Name = "PART_Name", Type = typeof(TextBlock))]
    [TemplatePart(Name = "PART_Bio", Type = typeof(TextBlock))]
    [TemplatePart(Name = "PART_TwitterLink", Type = typeof(HyperlinkButton))]
    [TemplatePart(Name = "PART_BlogLink", Type = typeof(HyperlinkButton))]
    [TemplatePart(Name = "PART_RateReviewButton", Type = typeof(HyperlinkButton))]
    [TemplatePart(Name = "PART_Feedback", Type = typeof(HyperlinkButton))]
    internal class AboutPageMobile : AboutPageBase
    {
        private Image _partImage;
        private TextBlock _partName;
        private TextBlock _partBio;
        private HyperlinkButton _partTwitterLink;
        private HyperlinkButton _partBlogLink;
        private HyperlinkButton _partRateReviewButton;
        private HyperlinkButton _partFeedback;
        private RateReminder _partRateReminder;

        public AboutPageMobile()
        {
            DefaultStyleKey = typeof(AboutPageMobile);
        }

        protected override void OnApplyTemplate()
        {
            _partImage = GetTemplateChild("PART_Photo") as Image;
            _partName = GetTemplateChild("PART_Name") as TextBlock;
            _partBio = GetTemplateChild("PART_Bio") as TextBlock;
            _partTwitterLink = GetTemplateChild("PART_TwitterLink") as HyperlinkButton;
            _partBlogLink = GetTemplateChild("PART_BlogLink") as HyperlinkButton;
            _partRateReviewButton = GetTemplateChild("PART_RateReviewButton") as HyperlinkButton;
            _partFeedback = GetTemplateChild("PART_Feedback") as HyperlinkButton;
            _partRateReminder = GetTemplateChild("PART_RateReminder") as RateReminder;

            if (_partBio != null)
            {
                _partBio.Text = _bio;
            }

            if (_partRateReviewButton != null && _partRateReminder != null)
            {
                _partRateReviewButton.Click += (s, a) =>
                {
                    _partRateReminder.ShowPopup();
                };
            }


            base.OnApplyTemplate();
        }
    }
}
