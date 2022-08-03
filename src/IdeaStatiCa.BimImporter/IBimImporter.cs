﻿using IdeaRS.OpenModel;
using IdeaStatiCa.BimApi;
using IdeaStatiCa.Plugin;
using System.Collections.Generic;

namespace IdeaStatiCa.BimImporter
{
	/// <summary>
	/// Provides conversion between BimApi and IOM.
	/// </summary>
	public interface IBimImporter
	{
		/// <summary>
		/// Imports specified objects into IOM.
		/// </summary>
		/// <param name="objects">Objects to import.</param>
		/// <returns>ModelBIM object.</returns>
		/// <param name="countryCode"></param>
		ModelBIM Import(IEnumerable<IIdeaObject> objects, CountryCode countryCode);

		/// <summary>
		/// Imports connections into IOM.
		/// </summary>
		/// <param name="coutryCode"></param>
		/// <returns>ModelBIM object.</returns>
		/// <exception cref="ConstraintException">Thrown when some constrain imposed on BimApi data is broken.</exception>
		ModelBIM ImportConnections(CountryCode coutryCode);

		/// <summary>
		/// Imports members into IOM.
		/// </summary>
		/// <param name="coutryCode"></param>
		/// <returns>ModelBIM object.</returns>
		/// <exception cref="ConstraintException">Thrown when some constrain imposed on BimApi data is broken.</exception>
		ModelBIM ImportMembers(CountryCode coutryCode);

		/// <summary>
		/// Reimports previously imported objects. 
		/// </summary>
		/// <param name="selected">List of objects to reimport.</param>
		/// <param name="coutryCode"></param>
		/// <returns>List of ModelBIM objects.</returns>
		List<ModelBIM> ImportSelected(List<BIMItemsGroup> selected, CountryCode countryCode);
	}
}