#region Copyright & License Information
/*
 * Copyright 2007-2020 The OpenRA Developers (see AUTHORS)
 * This file is part of OpenRA, which is free software. It is made
 * available to you under the terms of the GNU General Public License
 * as published by the Free Software Foundation, either version 3 of
 * the License, or (at your option) any later version. For more
 * information, see COPYING.
 */
#endregion

using OpenRA.FileSystem;
using OpenRA.Graphics;

namespace OpenRA.Mods.Common.Terrain
{
	public class DefaultTerrainLoader : ITerrainLoader
	{
		public DefaultTerrainLoader(ModData modData) { }

		public ITerrainInfo ParseTerrain(IReadOnlyFileSystem fileSystem, string path)
		{
			return new TileSet(fileSystem, path);
		}
	}
}