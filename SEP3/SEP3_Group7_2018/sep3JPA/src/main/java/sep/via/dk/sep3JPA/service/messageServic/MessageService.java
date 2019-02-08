package sep.via.dk.sep3JPA.service.messageServic;

import java.util.List;

import sep.via.dk.sep3JPA.domain.Message;

public interface MessageService {
	public void addMessage(Message feedBack);

	public List<Message> getAllMessage();
}
