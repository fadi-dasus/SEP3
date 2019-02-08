package sep.via.dk.sep3JPA.service.login;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import sep.via.dk.sep3JPA.dao.login.LoginDao;

@Service
public class LoginServiceImplementation implements LoginService {

	
	@Autowired
	private LoginDao loginDao;

	@Override
	public boolean customerAuthentication(String username, String password) {
		 if (loginDao.customerAuthentication(username,password) && loginDao.AuthenticateSubscription(username) ){
		        return true;
		    } 
		        return false;
		    
		
	}

	@Override
	public boolean ownerAuthentication(String username, String password) {

		 if (loginDao.ownerAuthentication(username,password) ){
		        return true;
		    } 
		        return false;
		    

}
}