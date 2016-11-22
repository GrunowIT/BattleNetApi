/*
    BattleNetApi - A .NET battle.net API library.
    Copyright (C) 2016  Sebastian Grunow <sebastian@grunow-it.de>

    This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program.  If not, see <http://www.gnu.org/licenses/>.
    */

using System;
using BattleNetApi.Client.Constants;
using BattleNetApi.Client.Extensions;

namespace BattleNetApi.Client
{
    public class ApiClientConfiguration
    {
        private Region _region;
        
        public TimeSpan ApiWaitingTimeSpan { get; }
        public Uri BaseUri { get; private set; }
        public Region Region
        {
            get { return _region; }
            set
            {
                _region = value;
                BaseUri = new Uri(value.GetBaseUrl());
            }
        }
        public Locale Locale { get; set; }
        public int MaxRequestsPerTimeSpan;
        public TimeSpan PerTimeSpan;

        public ApiClientConfiguration(Region region = Region.US, Locale locale = Locale.en_US,
            int maxRequestsPerTimeSpan = 50, TimeSpan? perTimeSpan = null, TimeSpan? apiWaitingTimeSpan = null)
        {
            Region = region;
            Locale = locale;
            MaxRequestsPerTimeSpan = maxRequestsPerTimeSpan;
            PerTimeSpan = perTimeSpan ?? TimeSpan.FromSeconds(1);
            ApiWaitingTimeSpan = apiWaitingTimeSpan ?? TimeSpan.FromSeconds(30);
        }
    }
}
