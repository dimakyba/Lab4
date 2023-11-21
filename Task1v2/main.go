package main

import (
	"fmt"
	"time"
)

func main() {
	var n uint
	fmt.Print("Введіть натуральне число: ")
	fmt.Scan(&n)
	// n = 40000
	result := fmt.Sprintf("%d", n)
	startTime := time.Now()
	for i := uint(n - 1); i > 0; i-- {
		result = fmt.Sprintf("%d %s", i, result)
	}

	fmt.Println(result)

	endTime := time.Now()
	elapsedTime := endTime.Sub(startTime).Milliseconds()
	fmt.Printf("Execution time: %dms\n", elapsedTime)

}
