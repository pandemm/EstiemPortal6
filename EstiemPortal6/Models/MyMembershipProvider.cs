using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Security;

namespace EstiemPortal6.Models
{
    public class MyMembershipProvider : MembershipProvider
    {
        public override string ApplicationName
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
        public override bool ChangePassword(string username, string oldPassword, string newPassword)
        {
            throw new NotImplementedException();
        }
        public override bool ChangePasswordQuestionAndAnswer(string username, string password, string newPasswordQuestion, string newPasswordAnswer)
        {
            throw new NotImplementedException();
        }
        public override MembershipUser CreateUser(string username, string password, string email, string passwordQuestion, string passwordAnswer, bool isApproved, object providerUserKey, out MembershipCreateStatus status)
        {
            throw new NotImplementedException();
        }
        public override bool DeleteUser(string username, bool deleteAllRelatedData)
        {
            throw new NotImplementedException();
        }
        public override bool EnablePasswordReset
        {
            get { throw new NotImplementedException(); }
        }
        public override bool EnablePasswordRetrieval
        {
            get { throw new NotImplementedException(); }
        }
        public override MembershipUserCollection FindUsersByEmail(string emailToMatch, int pageIndex, int pageSize, out int totalRecords)
        {
            throw new NotImplementedException();
        }
        public override MembershipUserCollection FindUsersByName(string usernameToMatch, int pageIndex, int pageSize, out int totalRecords)
        {
            throw new NotImplementedException();
        }
        public override MembershipUserCollection GetAllUsers(int pageIndex, int pageSize, out int totalRecords)
        {
            throw new NotImplementedException();
        }
        public override int GetNumberOfUsersOnline()
        {
            throw new NotImplementedException();
        }
        public override string GetPassword(string username, string answer)
        {
            throw new NotImplementedException();
        }
        public override MembershipUser GetUser(string username, bool userIsOnline)
        {
            throw new NotImplementedException();
        }
        public override MembershipUser GetUser(object providerUserKey, bool userIsOnline)
        {
            throw new NotImplementedException();
        }
        public override string GetUserNameByEmail(string email)
        {
            throw new NotImplementedException();
        }
        public override int MaxInvalidPasswordAttempts
        {
            get { throw new NotImplementedException(); }
        }
        public override int MinRequiredNonAlphanumericCharacters
        {
            get { throw new NotImplementedException(); }
        }
        public override int MinRequiredPasswordLength
        {
            get { throw new NotImplementedException(); }
        }
        public override int PasswordAttemptWindow
        {
            get { throw new NotImplementedException(); }
        }
        public override MembershipPasswordFormat PasswordFormat
        {
            get { throw new NotImplementedException(); }
        }
        public override string PasswordStrengthRegularExpression
        {
            get { throw new NotImplementedException(); }
        }
        public override bool RequiresQuestionAndAnswer
        {
            get { throw new NotImplementedException(); }
        }
        public override bool RequiresUniqueEmail
        {
            get { throw new NotImplementedException(); }
        }
        public override string ResetPassword(string username, string answer)
        {
            throw new NotImplementedException(); 
        }
        public override bool UnlockUser(string userName)
        {
            throw new NotImplementedException(); 
        }
        public override void UpdateUser(MembershipUser user)
        {
            throw new NotImplementedException(); 
        }

        public User User { get; private set; }

        public override bool ValidateUser(string username, string password)
        {
            // Takes username and password, checks that they exist on the database and returns either true or false
            // Should also update the LastLoggedIn field


            // If there is no username or the username is only whitespace, return false
            if (string.IsNullOrEmpty(username.Trim())) return false;
            // If there is no password or the password is only whitespace, return false
            if (string.IsNullOrEmpty(password.Trim())) return false;
            // Encrypts the password using MD5 and Base64
            string hash = EncryptPassword(password);
            // Gets us the user so we can compare the passwords
            User user = GetUser(username);
            if (user == null) return false;
            if (user.Password == hash)
            {
                HttpContext.Current.User = user;
                return true;
            }
            return false;
        }

        /// <summary>
        /// Procuses an MD5 hash string of the password
        /// </summary>
        /// <param name="password">password to hash</param>
        /// <returns>MD5 Hash string</returns>
        protected string EncryptPassword(string password)
        {
            // The old Estiem Portal first creates an md5 hash of the password and then converts it to base64 string.
            // The first line is copypasted from the web, not sure if it applies for us currently
            byte[] pwdBytes = Encoding.GetEncoding(1252).GetBytes(password);
            byte[] hashBytes = System.Security.Cryptography.MD5.Create().ComputeHash(pwdBytes);
            string PassWordHash = Convert.ToBase64String(hashBytes);
            return PassWordHash;
        }

        public User GetUser(string UserName)
        {
            // This method gets the user for the authentication
            // Should be a better way of doing this, at least try to get the code out of membership provider
            var db = new EstiemPortalContext();
            var u = (from m in db.PORTAL_User
                       where m.UserName == UserName
                       select new User {
                           UserId = m.Id,
                           UserName = m.UserName,
                           Password = m.HashPassword }).FirstOrDefault();
            return u;
        }
    }
}