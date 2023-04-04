namespace Meraki.Api.Interfaces.General.Organizations;

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface IOrganizations
{
	/// <summary>
	/// List the organizations that the user has privileges on
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	[Get("/organizations")]
	Task<List<Organization>> GetOrganizationsAsync(
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Create a new organization
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="createOrganization">Body for creating an organization</param>
	[Post("/organizations")]
	Task<Organization> CreateOrganizationAsync(
		[Body] OrganizationCreateRequest createOrganization,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Return an organization
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	[Get("/organizations/{organizationId}")]
	Task<Organization> GetOrganizationAsync(
		string organizationId,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Update an organization
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	/// <param name="updateOrganization">Body for updating an organization</param>
	[Put("/organizations/{organizationId}")]
	Task<Organization> UpdateOrganizationAsync(
		string organizationId,
		[Body] OrganizationUpdateRequest updateOrganization,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Delete an organization
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	[Delete("/organizations/{organizationId}")]
	Task DeleteOrganizationAsync(
		string organizationId,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Claim a list of devices, licenses, and/or orders into an organization
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	/// <param name="organizationClaimRequest">Body for making a claim request</param>
	[Post("/organizations/{organizationId}/claim")]
	Task<OrganizationClaimResponse> ClaimIntoOrganizationAsync(
		string organizationId,
		[Body] OrganizationClaimRequest organizationClaimRequest,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Create a new organization by cloning the addressed organization
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	/// <param name="cloneOrganization">Body for cloning an organization</param>
	[Post("/organizations/{organizationId}/clone")]
	Task<Organization> CloneOrganizationAsync(
		string organizationId,
		[Body] CloneOrganization cloneOrganization,
		CancellationToken cancellationToken = default);
}
