﻿using Refit;
using System.Reflection;

namespace Meraki.ApiChecker.Models;

public class MethodDetails
{
	public MethodInfo Method { get; set; }
	public HttpMethodAttribute RefitAttribute { get; set; }

	/// <summary>
	/// A List of Types used by this method that lack at least one ApiAccess attribute
	/// </summary>
	public List<string> DeficientDataModels { get; set; } = new();

	public Type? ResponseType { get; set; }

	public MethodDetails(MethodInfo method, HttpMethodAttribute refitAttribute)
	{
		Method = method;
		RefitAttribute = refitAttribute;
	}
}
