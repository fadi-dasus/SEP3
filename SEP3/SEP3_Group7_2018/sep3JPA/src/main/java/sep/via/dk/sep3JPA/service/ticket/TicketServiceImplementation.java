package sep.via.dk.sep3JPA.service.ticket;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import sep.via.dk.sep3JPA.dao.ticket.TicketDAO;
import sep.via.dk.sep3JPA.domain.Ticket;
import sep.via.dk.sep3JPA.payment.MyPayment;

@Service
public class TicketServiceImplementation implements TicketService {
	@Autowired
	private TicketDAO ticketDAO;
	
	@Autowired
	public MyPayment myPayment;
	

	@Override
	public boolean addTicket(Ticket ticket) {
		
		ticketDAO.addTicket(ticket);
		return true;

	}

	@Override
	public boolean checkPayment() {
		String paymentString = myPayment.ExecutePayment();
		if (paymentString.equalsIgnoreCase("approved")){
			return true;
		}
		else
		
		return false;
	}
	
	
	@Override
	public String getPaymentLink() {
		myPayment.createPaymentDetail();
		return myPayment.getHref();
	}

}
