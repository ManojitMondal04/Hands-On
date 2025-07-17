🔍 Difference Between Lab 1 & 2 vs Lab 3 & 4
Understanding the evolution across labs is essential to see how basic authentication grows into robust, secure, and role-aware authorization.

✅ Lab 1 vs Lab 2
Aspect	Lab 1 – JWT Authentication	Lab 2 – Protect API Endpoint Using JWT
🔑 Purpose	Issue JWT token on valid login	Use [Authorize] to protect endpoints
📄 Code Focus	AuthController.cs	SecureController.cs
🔐 Authentication Setup	Yes – Token creation using secret key	Yes – Verifies token before granting access
🧪 Testing	POST /api/Auth/login	GET /api/Secure/data
🚫 Without Token	No restriction	401 Unauthorized if no token
✔️ With Token	Returns JWT token	200 OK (if token is valid)
✅ Lab 3 vs Lab 4
Aspect	Lab 3 – Role-Based Authorization	Lab 4 – Handle Expired Tokens Gracefully
🧑‍💼 Role Support	Adds "Admin" role to JWT	No new roles, focuses on expiry detection
🔐 Authorization Type	[Authorize(Roles = "Admin")]	Checks for token expiration in JWT events
📄 Code Focus	AdminController.cs	Program.cs → options.Events.OnAuthenticationFailed
⏰ Token Expiry Handling	Not handled	Handles token expiry and adds response header
🧪 Testing	GET /api/Admin/dashboard	Use expired token → check header "Token-Expired": true
🔴 Error Insight	Generic 401 for any failure	Adds custom logic for token-expired handling

📦 Summary

| Feature                     | Lab 1 | Lab 2 | Lab 3 | Lab 4 |
|----------------------------|:-----:|:-----:|:-----:|:-----:|
| JWT Token Generation       |  ✅   |  ✅   |  ✅   |  ✅   |
| Secured Endpoints (Authorize) |  ❌   |  ✅   |  ✅   |  ✅   |
| Role-Based Access          |  ❌   |  ❌   |  ✅   |  ✅   |
| Expired Token Handling     |  ❌   |  ❌   |  ❌   |  ✅   |

✅ With each lab, we progressively added more real-world authentication features to our microservice — making it more production-ready and secure.