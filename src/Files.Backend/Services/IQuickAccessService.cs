﻿using System.Collections.Generic;
using System.Threading.Tasks;

namespace Files.App.ServicesImplementation
{
	public interface IQuickAccessService
	{
		/// <summary>
		/// Gets the list of quick access items
		/// </summary>
		/// <returns></returns>
		Task<List<string>> GetPinnedFoldersAsync();

		/// <summary>
		/// Pins a folder to the quick access list
		/// </summary>
		/// <param name="folderPath">The folder to pin</param>
		/// <returns></returns>
		Task PinToSidebar(string folderPath);

		/// <summary>
		/// Pins folders to the quick access list
		/// </summary>
		/// <param name="folderPaths">The array of folders to pin</param>
		/// <returns></returns>
		Task PinToSidebar(string[] folderPaths);

		/// <summary>
		/// Unpins a folder from the quick access list
		/// </summary>
		/// <param name="folderPath">The folder to unpin</param>
		/// <returns></returns>
		Task UnpinFromSidebar(string folderPath);

		/// <summary>
		/// Unpins folders from the quick access list
		/// </summary>
		/// <param name="folderPaths">The array of folders to unpin</param>
		/// <returns></returns>
		Task UnpinFromSidebar(string[] folderPaths);
	}
}