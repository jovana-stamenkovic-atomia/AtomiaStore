﻿/// <reference path="../../../../Scripts/jquery-2.1.3.intellisense.js" />
/// <reference path="../../../../Scripts/knockout-3.2.0.debug.js" />

(function ($, ko) {
    'use strict';

    /** Show or hide element with a jQuery slide animation. Binding option 'slideDuration' sets animation time in ms. */
    ko.bindingHandlers.slideVisible = {
        init: function (element, valueAccessor) {
            var val = ko.unwrap(valueAccessor());
            $(element).toggle(val);
        },
        update: function (element, valueAccessor, allBindings) {
            var val = ko.unwrap(valueAccessor()),
                duration = allBindings.get('slideDuration') || 500;

            if (val === true) {
                $(element).slideDown(duration);
            }
            else {
                $(element).slideUp(duration);
            }
        }
    };

}(jQuery, ko));
