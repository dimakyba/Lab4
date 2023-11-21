package main

import (
	"fmt"
	"strings"
	"time"
)

func Insert(b *strings.Builder, index int, str string) {
	s := b.String()
	b.Reset()
	b.WriteString(s[:index] + str + s[index:])
}

func main() {
	var n uint
	fmt.Print("Введіть натуральне число n: ")
	fmt.Scan(&n)
	// n = 400

	var builder strings.Builder
	startTime := time.Now()
	for i := uint(n); i > 0; i-- {
		Insert(&builder, 0, fmt.Sprintf("%d ", i))
	}
	result := builder.String()
	fmt.Println(result)

	endTime := time.Now()
	elapsedTime := endTime.Sub(startTime).Milliseconds()
	fmt.Printf("Execution time: %dms\n", elapsedTime)
}
