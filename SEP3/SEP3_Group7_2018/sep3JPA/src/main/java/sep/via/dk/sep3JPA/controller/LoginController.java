package sep.via.dk.sep3JPA.controller;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.HttpHeaders;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestParam;
import org.springframework.web.bind.annotation.RestController;

import sep.via.dk.sep3JPA.service.login.LoginService;

@RestController
@RequestMapping("/sep3/login")
public class LoginController {

	@Autowired
	private LoginService servic;

	@PostMapping("/customer")
	public ResponseEntity<Void> getValidateCusotmer(@RequestParam("username") String username,
			@RequestParam("password") String password) {
		boolean valid = servic.customerAuthentication(username, password);
		if (!valid)
			return new ResponseEntity<Void>(HttpStatus.CONFLICT);
		HttpHeaders headers = new HttpHeaders();

		return new ResponseEntity<Void>(headers, HttpStatus.OK);

	}
	
	@PostMapping("/owner")
	public ResponseEntity<Void> getValidateOwner(@RequestParam("username") String username,
			@RequestParam("password") String password) {
		boolean valid = servic.ownerAuthentication(username, password);
		if (!valid)
			return new ResponseEntity<Void>(HttpStatus.CONFLICT);
		HttpHeaders headers = new HttpHeaders();

		return new ResponseEntity<Void>(headers, HttpStatus.OK);

	}

}
