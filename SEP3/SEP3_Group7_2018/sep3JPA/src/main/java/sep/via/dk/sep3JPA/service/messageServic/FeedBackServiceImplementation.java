package sep.via.dk.sep3JPA.service.messageServic;

import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import sep.via.dk.sep3JPA.dao.message.MessageDAO;
import sep.via.dk.sep3JPA.domain.Message;

@Service
public class FeedBackServiceImplementation implements MessageService {
	@Autowired
	private MessageDAO feedBackDAO;

	@Override
	public void addMessage(Message feedBack) {
		feedBackDAO.addMessage(feedBack);

	}

	@Override
	public List<Message> getAllMessage() {
		return feedBackDAO.getAllMessages();
	}
	
	

}
