# oauthdemo
OAuth 2.0 / OpenID Connect Demo Application

*I am thinking of dropping support for AD FS and Azure Active Directory B2C.*
*No efforts have been made so far to implement ADAL and/or MSAL.*

*Not all possible scenarios and features might have been tested.*

**Due to a limitation in the Web Browser component used, it's recommended to use form_post Response Mode in interactive requests.**

Scenario:

#### HTTP Web Requests:
| STS | Client Type | Flow | Tested |
|---|---|---|---|
| Azure Active Directory (V1) | Public Client | Client Credentials| N/A |
|  |  | Resource Owner Password Credentials | No |
|  |  | Authorization Code | Yes |
|  |  | Implicit Grant | Yes |
|  |  | On-Behalf-Of | No |
|  |  | Device Code | Yes |
|  |  | Hybrid | Yes |
|  | Confidential Client (Client Credentials) | Client Credentials| Yes |
|  |  | Resource Owner Password Credentials | No |
|  |  | Authorization Code | Yes |
|  |  | Implicit Grant | Yes |
|  |  | On-Behalf-Of | No |
|  |  | Device Code | N/A |
|  |  | Hybrid | Yes |
|  | Confidential Client (Windows Integrated Authentication) | Client Credentials| N/A |
|  |  | Resource Owner Password Credentials | N/A |
|  |  | Authorization Code | N/A |
|  |  | Implicit Grant | N/A |
|  |  | On-Behalf-Of | N/A |
|  |  | Device Code | N/A |
|  |  | Hybrid | N/A |
|  | Confidential Client (Certificate) | Client Credentials| No |
|  |  | Resource Owner Password Credentials | No |
|  |  | Authorization Code | No |
|  |  | Implicit Grant | No |
|  |  | On-Behalf-Of | No |
|  |  | Device Code | N/A |
|  |  | Hybrid | No |
 
#### ADAL:

#### MSAL:
