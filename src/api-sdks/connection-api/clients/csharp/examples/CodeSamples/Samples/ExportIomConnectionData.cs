﻿using IdeaRS.OpenModel.Connection;
using IdeaStatiCa.Api.Connection.Model;
using IdeaStatiCa.ConnectionApi;

namespace CodeSamples
{
	public partial class ClientExamples
	{
		/// <summary>
		/// Gets the IOM Connection Data associated with a given connection.
		/// </summary>
		/// <param name="conClient">The connected API Client</param>
		public static async Task ExportIomConnectionData(ConnectionApiClient conClient) 
		{
			string filePath = "Inputs/HSS_norm_cond.ideaCon";
			ConProject conProject = await conClient.Project.OpenProjectAsync(filePath);

			//Get projectId Guid
			Guid projectId = conProject.ProjectId;
			var connections = await conClient.Connection.GetConnectionsAsync(projectId);
			int connectionId = connections[0].Id;

			ConnectionData conData = await conClient.Export.ExportIomConnectionDataAsync(projectId, connectionId);

			//Print the connection data to the Console.
			Console.WriteLine($"Number of Plates: { conData.Plates.Count()}");
			Console.WriteLine($"Number of BoltGrids: {conData.BoltGrids.Count()}");
			Console.WriteLine($"Number of Welds: {conData.Welds.Count()}");
			Console.WriteLine($"Number of Cuts: {conData.CutBeamByBeams.Count()}");

			await conClient.Project.CloseProjectAsync(projectId);
		}
	}
}
