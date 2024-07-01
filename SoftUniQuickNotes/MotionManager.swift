//
//  MotionManager.swift
//  SoftUniQuickNotes
//
//  Created by Ivan Chavdarov Ivanov on 30.01.24.
//

import Foundation
import CoreMotion

protocol MotionManagerDelegate: AnyObject {
    func didDetectTilt()
}

class MotionManager {
    
    private let motionManager = CMMotionManager()
    weak var delegate: MotionManagerDelegate?
    
    func startAccelerometerUpdates() {
        if motionManager.isAccelerometerAvailable {
            motionManager.accelerometerUpdateInterval = 0.1
            motionManager.startAccelerometerUpdates(to: OperationQueue.main) { data, error in
                if let error = error {
                    return
                }
                
                if let acceleration = data?.acceleration {
                    let tiltThreshold = 0.5
                    
                    if acceleration.z > tiltThreshold {
                        self.delegate?.didDetectTilt()
                    }
                }
            }
        }
    }
    
    func stopAccelerometerUpdates() {
        if motionManager.isAccelerometerActive {
            motionManager.stopAccelerometerUpdates()
        }
    }
}
