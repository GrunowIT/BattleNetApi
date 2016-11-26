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
using BattleNetApi.Client.Models.D3;

namespace BattleNetApi.Client.Extensions.Models.D3
{
    public static class ItemInfoBaseExtensions
    {
        public static ItemInfo GetItemInfoFromTooltipParams(this ItemInfoBase itemInfoBase, D3ApiClient d3ApiClient)
        {
            if (itemInfoBase == null)
                throw new ArgumentNullException(nameof(itemInfoBase));
            if (d3ApiClient == null)
                throw new ArgumentNullException(nameof(d3ApiClient));

            if (string.IsNullOrWhiteSpace(itemInfoBase.TooltipParams))
                return null;

            var tooltipData = itemInfoBase.TooltipParams.Split(new []{'/'}, 2);
            if (tooltipData.Length != 2)
                return null;
            if (tooltipData[0] != "item")
                return null;
            
            return d3ApiClient.GetDataItemInfo(tooltipData[1]);
        }
    }
}
