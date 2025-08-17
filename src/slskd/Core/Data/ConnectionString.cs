// <copyright file="ConnectionString.cs" company="slskd Team">
//     Copyright (c) slskd Team. All rights reserved.
//
//     This program is free software: you can redistribute it and/or modify
//     it under the terms of the GNU Affero General Public License as published
//     by the Free Software Foundation, either version 3 of the License, or
//     (at your option) any later version.
//
//     This program is distributed in the hope that it will be useful,
//     but WITHOUT ANY WARRANTY; without even the implied warranty of
//     MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//     GNU Affero General Public License for more details.
//
//     You should have received a copy of the GNU Affero General Public License
//     along with this program.  If not, see https://www.gnu.org/licenses/.
// </copyright>

namespace slskd;

/// <summary>
///     A primitive type to differentiate connection strings from other strings.
/// </summary>
public record ConnectionString
{
    public required string Value { get; init; }

    public static implicit operator ConnectionString(string value) => new() { Value = value };
    public static implicit operator string(ConnectionString connectionString) => connectionString.Value;
    public override string ToString() => Value;
}