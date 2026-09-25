\# BÁO CÁO BÀI TẬP LAB 3 - QUẢN LÝ KHÁCH SẠN



\## 1. Thông tin sinh viên

\- \*\*Họ và tên:Nguyễn Gia Phúc

\- \*\*Mã số sinh viên (MSSV):1250080147

\- \*\*Lớp / Khóa:12\_DH\_CNPM2

\---



\## 2. Tên bài Lab

\*\*LAB 3: HỆ THỐNG QUẢN LÝ KHÁCH SẠN

\---



\## 3. Môi trường \& Phiên bản phát triển

\- \*\*Hệ điều hành:\*\* Windows 10 / Windows 11

\- \*\*Công cụ phát triển (IDE):\*\* Microsoft Visual Studio 2022

\- \*\*Ngôn ngữ \& Framework:\*\* C# (.NET Framework 4.7.2)

\- \*\*Hệ quản trị CSDL:\*\* Microsoft SQL Server 2022 / SQL Server Management Studio (SSMS 16.0)



\---



\## 4. Nội dung đã thực hiện

Đã hoàn thành xây dựng CSDL `QuanLyKhachSan` và triển khai đầy đủ 5 Form chức năng cốt lõi theo đúng yêu cầu:



1\. \*\*`FrmPhongTienNghi` (Quản lý Phòng, Tiện nghi \& Lắp đặt):\*\*

&#x20;  - Quản lý danh mục phòng (thêm phòng, khu vực, sức chứa, đơn giá).

&#x20;  - Quản lý danh mục tiện nghi, loại tiện nghi, tình trạng thiết bị.

&#x20;  - Lập phiếu trang bị/luân chuyển tiện nghi vào các phòng.



2\. \*\*`FrmDatPhong` (Khách hàng, Đặt phòng \& Nhận phòng):\*\*

&#x20;  - Quản lý hồ sơ thông tin khách hàng (CMND/CCCD, Quốc tịch, SĐT).

&#x20;  - Lập phiếu đặt phòng: Cho phép chọn nhiều phòng cùng lúc, kiểm tra ràng buộc số người vượt sức chứa và tự động kiểm tra trùng lịch đặt.

&#x20;  - Nhận phòng \& Quản lý danh sách người lưu trú thực tế.

&#x20;  - Thao tác đánh dấu No-show cho khách không đến.



3\. \*\*`FrmDichVu` (Ghi nhận dịch vụ):\*\*

&#x20;  - Lọc các phiếu lưu trú có trạng thái "Đang ở".

&#x20;  - Ghi nhận phát sinh dịch vụ theo từng phòng và ngày sử dụng.

&#x20;  - Tự động kiểm tra và cộng dồn số lượng nếu cùng dịch vụ được sử dụng nhiều lần trong ngày.



4\. \*\*`FrmTraPhong` (Kiểm tra tài sản, Đền bù, Hóa đơn \& Trả phòng):\*\*

&#x20;  - Lập phiếu đền bù thiết bị khi phát sinh hư hỏng/mất mát tài sản.

&#x20;  - Lập hóa đơn tự động tính tổng tiền phòng (đơn giá x số ngày) và tổng tiền dịch vụ.

&#x20;  - Ghi nhận thanh toán nhiều lượt (Tiền mặt, Chuyển khoản, Thẻ, Ví điện tử).

&#x20;  - Kiểm tra ràng buộc: Chỉ cho phép Hoàn tất trả phòng (chuyển trạng thái phòng về "Trống") khi Hóa đơn đã được thanh toán 100%.



5\. \*\*`FrmThongKe` (Báo cáo \& Thống kê):\*\*

&#x20;  - Thống kê tổng hợp: Số phiếu đặt, lượt đang ở, số hóa đơn, tổng doanh thu và tổng tiền đền bù theo khoảng thời gian.

&#x20;  - Thống kê chi tiết dịch vụ: Tổng số lượng và tổng doanh thu thu được theo từng mã dịch vụ.



\---



\## 5. Kết quả đạt được

\- \*\*Kiến trúc code:\*\* Phân tầng rõ ràng. Dữ liệu xử lý tập trung tại `Data/Db.cs`, nghiệp vụ tập trung ở các lớp Service (`PhongTienNghiService`, `DatPhongService`, `DichVuService`, `TraPhongService`, `ThongKeService`), giao diện WinForms chỉ gọi hàm xử lý.

\- \*\*Ràng buộc nghiệp vụ (Business Rules):\*\* 

&#x20; - \[x] Không cho phép đặt phòng vượt sức chứa.

&#x20; - \[x] Không cho phép đặt trùng phòng trong khoảng thời gian đã có khách ở/đặt.

&#x20; - \[x] Không vượt quá số người đăng ký ban đầu khi thêm người lưu trú.

&#x20; - \[x] Tự động cộng dồn số lượng dịch vụ trùng trong ngày.

&#x20; - \[x] Khóa thao tác trả phòng nếu chưa thanh toán đủ 100% tiền hóa đơn.

\- \*\*Test Cases:\*\* Đã kiểm thử thành công toàn bộ các kịch bản kiểm thử (PT01-PT03, DP01-DP05, DV01-DV03, TP01-TP06, TK01-TK02).

