// MvxChildViewModelOwnerAdapter.cs

// MvvmCross is licensed using Microsoft Public License (Ms-PL)
// Contributions and inspirations noted in readme.md and license.txt
//
// Project Lead - Stuart Lodge, @slodge, me@slodge.com

using System;
using MvvmCross.Platform.Droid.Views;
using MvvmCross.Platform.Exceptions;

namespace MvvmCross.Droid.Views
{
    public class MvxChildViewModelOwnerAdapter : MvxBaseActivityAdapter
    {
        protected IMvxChildViewModelOwner ChildOwner => (IMvxChildViewModelOwner)Activity;

        public MvxChildViewModelOwnerAdapter(IMvxEventSourceActivity eventSource)
            : base(eventSource)
        {
            if (!(eventSource is IMvxChildViewModelOwner))
            {
                throw new MvxException("You cannot use a MvxChildViewModelOwnerAdapter on {0}",
                                       eventSource.GetType().Name);
            }
        }

        protected override void EventSourceOnDestroyCalled(object sender, EventArgs eventArgs)
        {
            ChildOwner.ClearOwnedSubIndicies();
            base.EventSourceOnDestroyCalled(sender, eventArgs);
        }

        protected override void EventSourceOnDisposeCalled(object sender, EventArgs eventArgs)
        {
            ChildOwner.ClearOwnedSubIndicies();
            base.EventSourceOnDisposeCalled(sender, eventArgs);
        }
    }
}