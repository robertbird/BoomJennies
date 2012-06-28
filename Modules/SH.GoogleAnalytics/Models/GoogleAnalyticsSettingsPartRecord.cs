﻿using Orchard.ContentManagement.Records;

namespace SH.GoogleAnalytics.Models {
	public class GoogleAnalyticsSettingsPartRecord : ContentPartRecord {
		/// <summary>
		/// Gets or sets the Google Analytics tracking key used to perform analytics tracking.
		/// </summary>
		public virtual string GoogleAnalyticsKey { get; set; }

		/// <summary>
		/// Gets or sets the override domain name that may optionally be used for performing things like multiple domain/sub-domain tracking.
		/// </summary>
		public virtual string DomainName { get; set; }

		/// <summary>
		/// Gets or sets whether the new Google Analytics asynchronous tracking method should be used.
		/// </summary>
		/// <value>Default value is <c>true</c>.</value>
		public virtual bool UseAsyncTracking { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether Google Analytics tracking will be included on /Admin pages.
		/// </summary>
		public virtual bool TrackOnAdmin { get; set; }

		/// <summary>
		/// Initializes a new instance of the <see cref="GoogleAnalyticsSettingsPartRecord"/> class. Sets the default value
		/// of <see cref="P:UseAsyncTracking"/> to <c>true</c> and <see cref="P:TrackOnAdmin"/> to <c>false</c>.
		/// </summary>
		public GoogleAnalyticsSettingsPartRecord() {
			UseAsyncTracking = true;
			TrackOnAdmin = false;
		}
	}
}