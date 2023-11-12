import { Component, ElementRef, OnInit, ViewChild } from '@angular/core';
import { PersonInfo } from '../shared/personInfo-model';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {

  private apiUrl = 'https://localhost:7136/api/PersonInfo/CreateDocument';
  personalInfo: PersonInfo;
  isFilled: boolean;

  formData = {
    name: '',
    address: '',
    email: '',
    phone: '',
    employerName: '',
    companyName: '',
    companyAddress: '',
    companyContacts: ''
  };

  constructor(private http: HttpClient){
  }

  ngOnInit(): void {
  }

  submitForm(form: any): void {
    if (form.valid) {
      debugger
      console.log('Form submitted successfully');
      // Add your form submission logic here
    } else {
      console.log('Please fill in all required fields');
    }
  }
  
   onGeneratePDF(
    nameInput: HTMLInputElement, 
    addressInput: HTMLInputElement, 
    emailInput: HTMLInputElement, 
    phoneInput: HTMLInputElement, 
    employerInput: HTMLInputElement, 
    companyInput: HTMLInputElement,
    companyAddressInput: HTMLInputElement,
    companyContactsInput: HTMLInputElement
    ){

      this.isFilled = true;

      this.personalInfo = new PersonInfo(nameInput.value, 
        addressInput.value, 
        emailInput.value, 
        phoneInput.value, 
        employerInput.value, 
        companyInput.value,
        companyAddressInput.value,
        companyContactsInput.value);
        debugger;
        this.sendData();
   }

   postData(data: any): Observable<any> {
    const headers = new HttpHeaders({ 'Content-Type': 'application/json' });

    return this.http.post(this.apiUrl, data, { headers: headers });
  }

  sendData() {
    this.postData(this.personalInfo).subscribe(
      response => {
        console.log('POST request successful', response);
      },
      error => {
        console.error('Error in POST request', error);
      }
    );
    }
}
