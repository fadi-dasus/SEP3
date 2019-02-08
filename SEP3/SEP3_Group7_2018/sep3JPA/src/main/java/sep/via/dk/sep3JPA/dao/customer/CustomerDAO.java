package sep.via.dk.sep3JPA.dao.customer;

import sep.via.dk.sep3JPA.domain.Customer;

public interface CustomerDAO  {
	void addCustomer(Customer customer);

	boolean customerExist(String username);

	Customer getCustomerById(int id);

	Customer getCustomerByUsername(String username);

}
