package sep.via.dk.sep3JPA.service.customerService;

import sep.via.dk.sep3JPA.domain.Customer;

public interface CustomerService {

	boolean addCustomer(Customer customer) ;

	Customer getCustomerById(int id) ;

	Customer getCustomerByUsername(String username) ;

	public boolean setExpiryDate(Customer customer);

	public String getPaymentLink();

	public boolean customerExist(String username);
	public boolean checkPayment() ;

}
