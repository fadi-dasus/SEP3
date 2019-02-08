package sep.via.dk.sep3JPA.service.login;

public interface LoginService {

	boolean customerAuthentication(String username,String password);

	boolean ownerAuthentication(String username, String password);
	
}
