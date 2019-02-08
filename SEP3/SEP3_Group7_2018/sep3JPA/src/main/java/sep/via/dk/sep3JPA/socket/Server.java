package sep.via.dk.sep3JPA.socket;

import java.io.DataInputStream;
import java.io.DataOutputStream;
import java.io.IOException;
import java.io.ObjectInputStream;
import java.net.ServerSocket;
import java.net.Socket;
import java.net.SocketException;

import org.springframework.stereotype.Component;
@Component
public class Server {
	private ServerSocket serverSocket = null;
	private Socket socket = null;
	private ObjectInputStream inStream = null;

	public Server() {

	}

	public void communicate() {
		while(0!=1) {
		try {
			ServerSocket serverSocket = new ServerSocket(4343, 10);
			Socket socket = serverSocket.accept();
			DataInputStream is = new DataInputStream(socket.getInputStream());
			DataOutputStream os = new DataOutputStream(socket.getOutputStream());

			// Receiving
			byte[] lenBytes = new byte[4];
			is.read(lenBytes, 0, 4);
			int len = (((lenBytes[3] & 0xff) << 24) | ((lenBytes[2] & 0xff) << 16) | ((lenBytes[1] & 0xff) << 8)
					| (lenBytes[0] & 0xff));
			byte[] receivedBytes = new byte[len];
			is.read(receivedBytes, 0, len);
			String received = new String(receivedBytes, 0, len);
			
			
			
			System.out.println("Server received: " + received);

			// Sending
			String toSend = "Dear " + received ;
			byte[] toSendBytes = toSend.getBytes();
			int toSendLen = toSendBytes.length;
			byte[] toSendLenBytes = new byte[4];
			toSendLenBytes[0] = (byte) (toSendLen & 0xff);
			toSendLenBytes[1] = (byte) ((toSendLen >> 8) & 0xff);
			toSendLenBytes[2] = (byte) ((toSendLen >> 16) & 0xff);
			toSendLenBytes[3] = (byte) ((toSendLen >> 24) & 0xff);
			os.write(toSendLenBytes);
			os.write(toSendBytes);
			

			socket.close();
			serverSocket.close();

		} catch (SocketException se) {
			System.exit(0);
		} catch (IOException e) {
			e.printStackTrace();
		}
		}
	}
}