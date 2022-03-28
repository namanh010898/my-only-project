

using System;
using System.Net.Mail;
 
public class clsMail
{
    private  readonly string _from = "anhnnse06182@fpt.edu.vn"; // Email của Sender (của bạn)
    private  readonly string _pass = "namanh1998"; // Mật khẩu Email của Sender (của bạn)
    
   public  string Send(string sendto, string subject)
    { 
        //Daihoc_FPT_News.Models.Post post1 : tham so t3
        //sendto: Email receiver (người nhận)
        //subject: Tiêu đề email
        //content: Nội dung của email, bạn có thể viết mã HTML
        //Nếu gửi email thành công, sẽ trả về kết quả: OK, không thành công sẽ trả về thông tin l�-i


        //< h4 > Dưới đây là thông tin sự kiện:</ h4 >


        //   < p > Thời gian: " + eventTime + @" </ p >

        //      < p > Nội dung: " + eventName + @".</ p >

        //         < p > Địa điểm sự kiện: " + eventAddress + @" </ a ></ p >
        try
        {
            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

            mail.From = new MailAddress(_from);
            mail.To.Add(sendto);
            mail.Subject = subject;
            mail.IsBodyHtml = true;

            string content = RegisterEventSuccess();
            mail.Body = content;


            mail.Priority = MailPriority.High;

            SmtpServer.Port = 587;
            SmtpServer.Credentials = new System.Net.NetworkCredential(_from, _pass);
            SmtpServer.EnableSsl = true;

            SmtpServer.Send(mail);
            return "OK";
        } catch(Exception)
        {
            return "Exception";
        } 

    }

    public static string RegisterEventSuccess()
    {
        string content = @"
            <!DOCTYPE html>
<html>
<head>

  <meta charset='utf-8'>
  <meta http-equiv='x-ua-compatible' content='ie=edge'>
  <title>Register Event Success</title>
  <meta name='viewport' content='width=device-width, initial-scale=1'>
  <link href='https://fonts.googleapis.com/css?family=Montserrat&display=swap' rel='stylesheet'>


  <style type='text/css'>
  /**
   * Google webfonts. Recommended to include the .woff version for cross-client compatibility.
   */
  

  /**
   * Avoid browser level font resizing.
   * 1. Windows Mobile
   * 2. iOS / OSX
   */
  body,
  table,
  td,
  a {
    -ms-text-size-adjust: 100%; /* 1 */
    -webkit-text-size-adjust: 100%; /* 2 */
  }

  /**
   * Remove extra space added to tables and cells in Outlook.
   */
  table,
  td {
    mso-table-rspace: 0pt;
    mso-table-lspace: 0pt;
  }

  /**
   * Better fluid images in Internet Explorer.
   */
  img {
    -ms-interpolation-mode: bicubic;
  }

  /**
   * Remove blue links for iOS devices.
   */
  a[x-apple-data-detectors] {
    font-family: inherit !important;
    font-size: inherit !important;
    font-weight: inherit !important;
    line-height: inherit !important;
    color: inherit !important;
    text-decoration: none !important;
  }

  /**
   * Fix centering issues in Android 4.4.
   */
  div[style*='margin: 16px 0;'] {
    margin: 0 !important;
  }

  body {
    width: 100% !important;
    height: 100% !important;
    padding: 0 !important;
    margin: 0 !important;
  }

  /**
   * Collapse table borders to avoid space between cells.
   */
  table {
    border-collapse: collapse !important;
  }

  a {
    color: #1a82e2;
  }

  img {
    height: auto;
    line-height: 100%;
    text-decoration: none;
    border: 0;
    outline: none;
  }
  .passwordValue{
    display: none;
  }

  .showEmailButton:active{
    background: green !important;
  }
  .showEmailButton:active .passwordValue{
    display: block !important;
  }
  .showEmailButton:active .passwordDummy{
    display: none !important;
  }
  </style> 
</head>
<body style='background-color: #e9ecef;'>

  <!-- start preheader -->
  <div class='preheader' style='display: none; max-width: 0; max-height: 0; overflow: hidden; font-size: 1px; line-height: 1px; color: #fff; opacity: 0;'>
    
  </div>
  <!-- end preheader -->

  <!-- start body -->
  <table border='0' cellpadding='0' cellspacing='0' width='100%'>

    <!-- start logo -->
    <tr>
      <td align='center' bgcolor='#e9ecef'>
        <!--[if (gte mso 9)|(IE)]>
        <table align='center' border='0' cellpadding='0' cellspacing='0' width='600'>
        <tr>
        <td align='center' valign='top' width='600'>
        <![endif]-->
        <table border='0' cellpadding='0' cellspacing='0' width='90%' style='margin: 0 5%'>
          <tr>
            <td align='center' valign='top' style='padding: 36px 24px;'>
              <a href='#' target='_blank' style='display: inline-block;'>
                <img src='https://upload.wikimedia.org/wikipedia/vi/1/1d/Logo_%C4%90%E1%BA%A1i_h%E1%BB%8Dc_FPT.png' alt='Logo' border='0'   style='display: block; min-width: 48px;'>
              </a>
            </td>
          </tr>
        </table>
        <!--[if (gte mso 9)|(IE)]>
        </td>
        </tr>
        </table>
        <![endif]-->
      </td>
    </tr>
    <!-- end logo -->

    <!-- start hero -->
    <tr>
      <td align='center' bgcolor='#e9ecef'>
        <!--[if (gte mso 9)|(IE)]>
        <table align='center' border='0' cellpadding='0' cellspacing='0' width='600'>
        <tr>
        <td align='center' valign='top' width='600'>
        <![endif]-->
        <table border='0' cellpadding='0' cellspacing='0' width='100%' style='max-width: 600px;'  >
          <tr>
            <td align='left' bgcolor='#ffffff' style='padding: 36px 24px 0; font-family: Roboto,RobotoDraft,Helvetica,Arial,sans-serif; border-top: 3px solid #d4dadf;'>
              <h1 style='margin: 0; font-size: 32px; font-weight: 700; letter-spacing: -1px; line-height: 48px;'>Đăng ký tham gia sự kiện thành công</h1>
            </td>
          </tr>
        </table>
        <!--[if (gte mso 9)|(IE)]>
        </td>
        </tr>
        </table>
        <![endif]-->
      </td>
    </tr>
    <!-- end hero -->

    <!-- start copy block -->
    <tr>
      <td align='center' bgcolor='#e9ecef'>
        <!--[if (gte mso 9)|(IE)]>
        <table align='center' border='0' cellpadding='0' cellspacing='0' width='600'>
        <tr>
        <td align='center' valign='top' width='600'>
        <![endif]-->
        <table border='0' cellpadding='0' cellspacing='0' width='100%' style='max-width: 600px;' class='showEmailButton'>

          <!-- start copy -->
          <tr>
            <td align='left' bgcolor='#ffffff' style='padding: 24px; font-family: Roboto,RobotoDraft,Helvetica,Arial,sans-serif; font-size: 16px; line-height: 24px;'>
              <p style='margin: 0; padding-bottom: 10px;font-size: 18px!important;'>Thân chào, cảm ơn bạn đã đăng ký tham gia sự kiện <b></b></p>
                    <h4>Cảm ơn bạn đã đăng ký tham dự sự kiện của chúng tôi.</h4>
                     
                    <p>Hẹn gặp bạn tại sự kiện!</p>
   
               </td>
   
             </tr>
   
             <!--end copy-->
   

             <!--start copy-->
   
             <tr>
   
               <td align = 'left' bgcolor = '#ffffff' style = 'padding: 24px; font-family: Roboto,RobotoDraft,Helvetica,Arial,sans-serif; font-size: 16px; line-height: 24px; border-bottom: 3px solid #d4dadf'>
        
                      <p style = 'margin: 0;'> Trân trọng! <br> Đai học FPT  <br> Trường công nghệ cao Đại học</p>
                  
                              </td>
                  
                            </tr>
                  
                            <!--end copy-->
                  

                          </table>
                  
                          <!--[if (gte mso 9)| (IE)]>
                    
                            </td>
                    
                            </tr>
                    
                            </table>
                    
                            <![endif]-- >
                    
                          </td>
                    
                        </tr>
                    
                        <!--end copy block-->
                    

                        <!--start footer-->
                    
                        <tr>
                    
                          <td align = 'center' bgcolor = '#e9ecef' style = 'padding: 24px;'>
                         
                                 <!--[if (gte mso 9)| (IE)]>
                           
                                   <table align = 'center' border = '0' cellpadding = '0' cellspacing = '0' width = '600'>
                                    
                                            <tr>
                                    
                                            <td align = 'center' valign = 'top' width = '600'>
                                         
                                                 <![endif]-->
                                         
                                                 <table border = '0' cellpadding = '0' cellspacing = '0' width = '100%' style = 'max-width: 600px;'>
                                                  

                                                            <!--start permission-->
                                                  
                                                            <tr>
                                                  
                                                              <td align = 'center' bgcolor = '#e9ecef' style = 'padding: 12px 24px; font-family: Roboto,RobotoDraft,Helvetica,Arial,sans-serif; font-size: 14px; line-height: 20px; color: #666;'>
                                                       
                                                                     <p style = 'margin: 0;' > Bạn nhận được email này vì chúng tôi đã nhận được yêu cầu từ tài khoản của bạn.</p>
                                                            
                                                                        </td>
                                                            
                                                                      </tr>
                                                            
                                                                      <!--end permission-->
                                                            

                                                                      <!--start unsubscribe-->
                                                            
                                                                      <tr>
                                                            
                                                                        <td align = 'center' bgcolor = '#e9ecef' style = 'padding: 12px 24px; font-family: Roboto,RobotoDraft,Helvetica,Arial,sans-serif; font-size: 14px; line-height: 20px; color: #666;'>
                                                                 
                                                                               <p style = 'margin: 0;' > Copyright 2022 <a href = '' target = '_blank' > A2F </a></p>
                                                                             
                                                                                           <p style = 'margin: 0;' > All rights reserved.</p>
                                                                                  
                                                                                              </td>
                                                                                  
                                                                                            </tr>
                                                                                  
                                                                                            <!--end unsubscribe-->
                                                                                  

                                                                                          </table >
                                                                                  
                                                                                          <!--[if (gte mso 9)| (IE)]>
                                                                                    
                                                                                            </td>
                                                                                    
                                                                                            </tr>
                                                                                    
                                                                                            </table>
                                                                                    
                                                                                            <![endif]-->
                                                                                    
                                                                                          </td>
                                                                                    
                                                                                        </tr>
                                                                                    
                                                                                        <!--end footer-->
                                                                                    

                                                                                      </table>
                                                                                    
                                                                                      <!--endbody-->
                                                                                    

                                                                                    </body>
                                                                                    </html>



                                                                                                                                                                   ";
        return content;
    }

}