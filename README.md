### Description

Create an API endpoint to handle the deletion of an organization. This endpoint will validate the organization ID and remove the specified organization from the system upon successful validation.

### Acceptance Criteria

#### API Endpoint Implementation:

- The endpoint should be accessible at `/api/organizations`.
- The endpoint should accept HTTP DELETE requests.
- The endpoint should be protected and require authentication.

#### Data Validation and Sanitization:

- The API should validate the request payload to ensure the organization ID is present and valid.
- The organization ID should be checked for correctness and validity (e.g., it exists in the system).
- The API should verify that the authenticated user is the owner of the organization.

#### Deleting Organization:

- Upon successful validation of the organization ID, the organization should be removed from the system.
- All related data should be handled according to the defined data retention policy.

#### Response:

- On success, the API should return a 204 No Content status code.
- On failure, the API should return an appropriate status code with error messages.

#### Request Example:
```http
DELETE /api/organizations
Content-Type: application/json
Authorization: Bearer <token>

{
  "organizationId": "string"
}

```

#### Successful Response:

204 No Content

#### Error Response:

```json
{
  "message": "Failed to delete organization",
  "errors": [
    "Invalid organization ID format"
  ],
  "status": 400
}
```
```json
{
  "message": "Failed to delete organization",
  "errors": [
    "User not authorized to delete this organization"
  ],
  "status": 401
}
```

### Purpose

Provides a backend service to handle the deletion of organizations, ensuring the organization ID is valid and removing the organization from the system.

### Requirements

- Develop server-side logic to handle organization deletion requests.
- Validate and sanitize incoming organization ID data.
- Remove the specified organization upon successful validation of the organization ID.
- Handle all related data according to the defined data retention policy.

### Expected Outcome

The API endpoint allows users to delete an organization by providing the organization ID, ensuring the organization is removed from the system.

### Status Codes

- **204**: Organization was successfully deleted.
- **400**:
  - Invalid organization ID format
  - Organization not found
- **401**:
  - User not allowed to perform this action
- **500**: A server error occurred

### Testing

- Write unit tests to ensure the organization deletion endpoint validates input correctly and removes the organization from the system.
- Test various scenarios for submitting the organization ID (e.g., valid ID, non-existent ID, malformed ID, etc.).


