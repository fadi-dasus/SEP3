package sep.via.dk.sep3JPA.controller;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.HttpHeaders;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestParam;
import org.springframework.web.bind.annotation.RestController;

import sep.via.dk.sep3JPA.domain.Customer;
import sep.via.dk.sep3JPA.service.customerService.CustomerService;

@RestController
@RequestMapping("/sep3")
public class CustomerController {

	@Autowired
	private CustomerService customerService;

	@GetMapping("/customer/{id}")
	public ResponseEntity<Customer> getCustomerById(@PathVariable("id") Integer id) {
		Customer customer = customerService.getCustomerById(id);
		return new ResponseEntity<Customer>(customer, HttpStatus.OK);

	}

	@PostMapping("/customer")
	public ResponseEntity<Void> addCustomer(@RequestBody Customer customer)  {
		boolean exist = customerService.setExpiryDate(customer);
		if (!exist)
			return new ResponseEntity<Void>(HttpStatus.CONFLICT);
		HttpHeaders headers = new HttpHeaders();

		return new ResponseEntity<Void>(headers, HttpStatus.CREATED);

	}

	@GetMapping("/customer/username")
	public ResponseEntity<Customer> getCustomerByUsername(@RequestParam("username") String username)
			 {

		Customer customer = customerService.getCustomerByUsername(username);

		return new ResponseEntity<Customer>(customer, HttpStatus.OK);
	}

	@GetMapping("/customer/link")
	public ResponseEntity<String> getPaymentLink(@RequestParam("username") String username){
		boolean customerExist = customerService.customerExist(username);
		if(customerExist) {
			String text = "customer is already there ";
			return new ResponseEntity<String>(text,HttpStatus.CONFLICT);
		}
		String link = customerService.getPaymentLink();

		return new ResponseEntity<String>(link, HttpStatus.OK);
	}

}
