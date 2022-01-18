# TUTORIAL VALIDATION FRAMEWORK
-------------
## Thông tin nhóm
| MSSV     | Họ và tên       |
| -------- | --------------- |
| 18120467 | Huỳnh Quang Nam |
| 18120542 | Nguyễn Tiến Tài |
| 18120439 | Trần Đức Lộc |
| 18120452 | Phạm Hoàng Long |
| 18120442 | Cam Quốc Bảo Long |

## Chức năng cơ bản
`ValidationFramework` hỗ trợ một số các thao tác cơ bản sau:
1.	Cơ chế thông báo khi data không valid
2.	Thao tác thiết lập valid bằng code
3.	Thao tác thiết lập valid tự động thông qua khai báo ràng buộc dữ liệu
4.	Có thể kết hợp các validation với nhau cho cùng kiểu dữ liệu 
5.	Hỗ trợ kết hợp regular expression
6.	Cho phép tạo custom validation

## Hướng dẫn cài đặt
- Bước 1: Truy cập link github: https://github.com/phlonghcmus/DesignPattern.git và pull source về
- Bước 2: Copy folder `ValidationFramework` vào source code của bạn
- Bước 3: Import `ValidationFramework` vào chương trình để sử dụng

## Hướng dẫn sử dụng
### Sử dụng các Validator sẵn có
- Bước 1: Tạo một class bất kỳ và import `ValidationFramework`
- Bước 2: Thêm các `Validator` vào các trường thuộc tính của class
- Bước 3: Tại chương trình main, khởi tạo `Validation` và sử dụng phương thức `Validation.validate()` để kiểm tra dữ liệu truyền vào
- Bước 4: Phương thức `Validation.validate()` sẽ trả về mảng Violation chứa các thông báo vi phạm 

### Custom Validator theo nhu cầu
- Bước 1: Tạo folder `CustomValidate`
- Bước 2: Tạo 2 class lần lượt kế thừa class `Anotation` và `Validator`
- Bước 3: Implement các phương thức được kế thừa từ 2 class 
- Bước 4: Sử dụng tương tự `Validator` sẵn có ở trên

Lưu ý: Tại chương trình main, ta cần thêm `Validator` mới vào `ValidatorFactory` bằng phương thức `ValidatorFactory.addValidator()`

## Video demo

- Github: https://github.com/phlonghcmus/DesignPattern.git
- Video demo: https://youtu.be/0PLtsukU_vc

