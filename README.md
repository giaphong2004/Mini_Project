# Mini_Project

Đây là bộ 3 bài tập cơ bản mà em đã thực hiện trong quá trình làm quen với **ASP.NET Core MVC**.  
Thông qua các bài tập này em nắm rõ hơn về:  
- Cách tổ chức project ASP.NET Core  
- Luồng dữ liệu từ **Controller → View**  
- Cách sử dụng `ViewBag` để truyền dữ liệu  
- Xử lý form trong MVC (nhập dữ liệu, gửi mail, upload file)  
- Tích hợp các chức năng thường gặp trong một ứng dụng web thực tế.  

---

## 📘 Bài tập 1: Máy tính cộng trừ đơn giản

**Mục tiêu học tập:**  
- Làm quen với mô hình MVC: người dùng nhập dữ liệu trên view, dữ liệu gửi về controller, controller xử lý và trả kết quả về lại view.  
- Sử dụng `ViewBag` để truyền dữ liệu động từ controller sang view.  

**Mô tả:**  
- Người dùng nhập **Số A** và **Số B**.  
- Chọn phép toán (cộng / trừ).  
- Controller sẽ nhận request, tính toán kết quả, rồi gán kết quả vào `ViewBag.Result`.  
- Trên view hiển thị kết quả ngay sau khi người dùng bấm nút `=`.  

**Ảnh minh họa:**  
<img width="804" height="600" alt="image" src="https://github.com/user-attachments/assets/ff1cc7f9-edd7-4bbe-a71e-cb4d29f96b9c" />

---

## 📧 Bài tập 2: Gửi mail từ form liên hệ

**Mục tiêu học tập:**  
- Hiểu cách gửi email trong ASP.NET Core.  
- Thấy được tính ứng dụng của tính năng gửi mail trong các hệ thống web.  

**Mô tả:**  
- Người dùng điền thông tin vào form liên hệ (tên, email, nội dung).  
- Khi nhấn **Gửi**, hệ thống sẽ tạo một email và gửi đến địa chỉ mail chung của bộ phận chăm sóc khách hàng.  
- Đây là chức năng thường thấy trong website: dùng để nhận phản hồi, góp ý, hỗ trợ khách hàng.  

**Điểm quan trọng:**  
- Cách cấu hình SMTP trong ASP.NET Core.  
- Bảo mật thông tin tài khoản mail (sử dụng app password hoặc config riêng).  
- Xử lý lỗi trong quá trình gửi mail (VD: sai định dạng email, server không kết nối được…).  

**Ảnh minh họa:**  
<img width="785" height="591" alt="image" src="https://github.com/user-attachments/assets/8dcf6bd9-6ed2-4e0c-bf86-825c95db29c0" />

---

## 📂 Bài tập 3: Upload ảnh và file

**Mục tiêu học tập:**  
- Hiểu quy trình upload file trong ASP.NET Core.  
- Biết cách phân biệt file ảnh và file thường để hiển thị khác nhau.  
- Biết cách lưu file vào thư mục `wwwroot` để có thể truy cập qua trình duyệt.  

**Mô tả:**  
- Người dùng chọn một file bất kỳ (ảnh hoặc văn bản).  
- Nếu là **ảnh**: sau khi upload, hệ thống hiển thị ảnh ngay trên web.  
- Nếu là **file khác**: hệ thống hiển thị link download và thông tin file (tên, kích thước, loại).  

**Điểm quan trọng:**  
- Kiểm tra `ContentType` hoặc phần mở rộng để xác định loại file.  
- Sử dụng `FileStream` để lưu file từ `IFormFile` vào `wwwroot/UploadFiles`.  
- Xử lý trường hợp không cho phép upload file dung lượng quá lớn hoặc định dạng nguy hiểm.  

**Ảnh minh họa:**  
<img width="988" height="666" alt="image" src="https://github.com/user-attachments/assets/96aaaf39-c15c-4cec-ae7c-9ff9d976be79" />

---

## 🎯 Kết quả đạt được

Sau 3 bài tập, em đã:  
- Làm quen với ASP.NET Core MVC cơ bản.  
- Hiểu cách hoạt động của **Controller – View – Model** trong xử lý dữ liệu.  
- Biết cách gửi dữ liệu qua form, validate cơ bản, hiển thị kết quả cho người dùng.  
- Tích hợp được các tính năng nền tảng: tính toán, gửi mail, upload file – những thứ thường xuất hiện trong các hệ thống web thực tế.  
