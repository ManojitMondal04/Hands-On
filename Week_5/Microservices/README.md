🔍 Comparison Between Lab 1 & 2 vs Lab 3 & 4
Understanding how the labs evolve helps you see the journey from simple JWT setup to a fully secure and role-aware API authentication system.

✅ Lab 1 vs Lab 2
Criteria	Lab 1 – Basic JWT Authentication	Lab 2 – Securing API Using JWT
🔑 Goal	Generate JWT upon valid user login	Restrict access to endpoints using [Authorize]
📄 Key File	AuthController.cs	SecureController.cs
🔐 Auth Mechanism	Yes – Token created with a secret key	Yes – Token validation before access
🧪 How to Test	POST /api/Auth/login	GET /api/Secure/data
🚫 Access Without Token	Open access	Returns 401 Unauthorized
✔️ Access With Token	Provides JWT	Returns 200 OK if token is valid

✅ Lab 3 vs Lab 4
Criteria	Lab 3 – Role-Based Access Control	Lab 4 – Graceful Handling of Expired Tokens
🧑‍💼 Role Integration	Includes "Admin" role in JWT	No role changes; focuses on token expiration
🔐 Authorization Type	[Authorize(Roles = "Admin")]	Uses OnAuthenticationFailed for expired tokens
📄 Key File	AdminController.cs	Program.cs → options.Events.OnAuthenticationFailed
⏰ Token Expiry	Not addressed	Adds logic to detect and handle expiry
🧪 How to Test	GET /api/Admin/dashboard	Use an expired token and inspect response header
🔴 Error Feedback	Generic 401 Unauthorized	Adds "Token-Expired": true in the response

📦 Feature Matrix
Capability	Lab 1	Lab 2	Lab 3	Lab 4
JWT Creation	✅	✅	✅	✅
Endpoint Security with [Authorize]	❌	✅	✅	✅
Role-Based Authorization	❌	❌	✅	✅
Token Expiry Detection/Handling	❌	❌	❌	✅

