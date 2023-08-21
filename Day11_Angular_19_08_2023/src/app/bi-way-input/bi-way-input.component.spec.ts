import { ComponentFixture, TestBed } from '@angular/core/testing';

import { BiWayInputComponent } from './bi-way-input.component';

describe('BiWayInputComponent', () => {
  let component: BiWayInputComponent;
  let fixture: ComponentFixture<BiWayInputComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [BiWayInputComponent]
    });
    fixture = TestBed.createComponent(BiWayInputComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
