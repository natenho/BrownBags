	public class UserValidator
	{
		public bool CheckPassword(string userName, string password)
		{
			var user = userRepository.FindByName(userName);
			if (user == null)
			{
				throw new UserNotFoundException(userName);
			}
	
			var codedPhrase = user.GetPhraseEncodedByPassword();
			var phrase = cryptographer.Decrypt(codedPhrase, password);
			
			if ("Valid Password".Equals(phrase))
			{
				Session.Initialize();
				return true;
			}
	
			return false;
		}
	}
