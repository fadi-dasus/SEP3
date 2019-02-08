package sep.via.dk.sep3JPA.payment;

import java.util.ArrayList;
import java.util.Iterator;
import java.util.List;

import org.springframework.stereotype.Service;

import com.paypal.api.payments.Amount;
import com.paypal.api.payments.Links;
import com.paypal.api.payments.Payer;
import com.paypal.api.payments.Payment;
import com.paypal.api.payments.PaymentExecution;
import com.paypal.api.payments.RedirectUrls;
import com.paypal.api.payments.Transaction;
import com.paypal.base.rest.APIContext;
import com.paypal.base.rest.PayPalRESTException;

@Service
public class MyPayment {

	public static final String clientID = "Aco76YrSixRHvke9vvKJ4vwhivkkklcMA6mMT6LAaUeIN76mrpu5XfjD6AnDlkvnKIC-nfH9EWKBh5xW";
	public static final String clientSecret = "EPnItkPLzQVOK6dmKatRbyCREvhzGcf6VRQHE89nHFN2LSBW4I5QEs7fiXbQKXNNotAI9D469mFG4VwI";
	public static final String mode = "sandbox";

	public static Payment payment = new Payment();
	public Payment payment1 = null;

	public static APIContext apiContext = new APIContext(clientID, clientSecret, "sandbox");
	public static RedirectUrls redirectUrls = new RedirectUrls();

	public String href = null;

	public String getHref() {
		return href;
	}

	public void setHref(String href) {
		this.href = href;
	}

	public void createPaymentDetail() {
		Amount amount = new Amount();
		amount.setCurrency("USD");
		amount.setTotal("1.00");

		Transaction transaction = new Transaction();
		transaction.setAmount(amount);
		List<Transaction> transactions = new ArrayList<Transaction>();
		transactions.add(transaction);

		Payer payer = new Payer();
		payer.setPaymentMethod("paypal");

		payment.setIntent("sale");
		payment.setPayer(payer);

		payment.setTransactions(transactions);

		redirectUrls.setCancelUrl("https://example.com/cancel");
		// redirectUrls.setReturnUrl("https://example.com/return");
		redirectUrls.setReturnUrl("https://localhost:8443/sep3/ticket/link/thanks");

		payment.setRedirectUrls(redirectUrls);

		try {

			payment.create(apiContext);

		} catch (PayPalRESTException e) {
			// Handle errors
		} catch (Exception ex) {
			// Handle errors
		}

		try {
			payment1 = payment.create(apiContext);
			Iterator links = payment1.getLinks().iterator();

			while (links.hasNext()) {
				Links link = (Links) links.next();
				System.out.println();
				System.out.println(link.toString());
				if (link.getRel().equalsIgnoreCase("approval_url")) {
					href = link.getHref();
				}
			}
		} catch (PayPalRESTException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}

	}

	public String ExecutePayment() {
		try {

			PaymentExecution paymentExecution = new PaymentExecution();

			paymentExecution.setPayerId("DUSYFH5YB7NC8");
if(payment1!=null) {
			Payment payment2 = payment1.execute(apiContext, paymentExecution);

			String str2 = payment2.getState();
			if (str2 != null) {

				return str2;
			}
}
		} catch (PayPalRESTException e) {
			System.out.println("payment failed ");
		}

		return "no payment";

	}
}
